using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1

{
   
    public class Dados
    {
     
        ///Objeto que mant�m a conex�o com o banco.
      
        private MySqlConnection objConexao = null;

        public Dados()
        {
            Conectar();
        }

       #region M�todos Privados

        #region Conectar()
        /// <summary>
        /// Inicia uma conex�o com o banco de dados.
        /// </summary>
        private void Conectar()
        {
            string server = "localhost";
            string user = "root";
            string password = "";
            string database = "CantinaBiometrica";

            // string de conex�o 
            string strStringConexao = "SERVER=" + server + ";DATABASE=" + database +
                          ";UID=" + user + ";PASSWORD=" + password + ";";

            // Cria uma conex�o com o banco de dados.
            objConexao = new MySqlConnection(strStringConexao);

            // Abre a conex�o.
            objConexao.Open();
        }
        #endregion

        #region Desconectar()
        /// <summary>
        /// Fecha a conex�o com o banco de dados.
        /// </summary>
        private void Desconectar()
        {
            // Fecha a conex�o.
            objConexao.Close();
        }
        #endregion

        #endregion

       #region M�todos P�blicos

        #region ConvertSqlToDataTable(string)
        /// <summary>
        /// Executa um comando SQL e retorna um
        /// DataTable preenchido com o resultado
        /// da pesquisa.
        /// </summary>
        /// <param name="p_strComandoSQL">
        /// String contendo o comando SQL a ser executado.
        /// </param>
        /// <returns>
        /// DataTable com o resultado da consulta.
        /// </returns>

        public DataTable ConvertSqlToDataTable(string p_strComandoSQL)
        {
            // Executa o comando SQL sem passar par�metros.
            return ConvertSqlToDataTable(p_strComandoSQL,null);
        }

        #endregion

        #region ConvertSqlToDataTable(string, SqlParameter[])
        /// <summary>
        /// Executa um comando SQL e retorna um
        /// DataTable preenchido com o resultado
        /// da pesquisa.
        /// </summary>
        /// <param name="p_strComandoSQL">
        /// String contendo o comando SQL a ser executado.
        /// </param>
        /// <param name="p_arrParametros">
        /// Cole��o de par�metros utilizados pelo comando SQL.
        /// </param>
        /// <returns>
        /// DataTable com o resultado da consulta.
        /// </returns>
        public DataTable ConvertSqlToDataTable(string p_strComandoSQL,
            params MySqlParameter[] p_arrParametros)
        {
            // Conecta ao banco.
            Conectar();

            // Instancia um DataTable de resultado.
            DataTable tblResultado = new DataTable();

            try
            {
                #region Cria comando SQL

                // Instancia um comando SQL a ser executado.
                MySqlCommand objComandoSQL = new MySqlCommand();

                objComandoSQL.Connection = objConexao;
                objComandoSQL.CommandText = p_strComandoSQL;
                #endregion

                #region Adiciona par�metros ao comando
                // Verifica se existem par�metros.
                if (p_arrParametros != null)
                {
                    // Percorre cada par�metro recebido.
                    foreach (MySqlParameter objParametro
                        in p_arrParametros)
                    {
                        // Adiciona ao comando SQL.
                        objComandoSQL.Parameters.Add(
                            objParametro);
                    }
                }
                #endregion

                #region Executa o comando SQL

                // Define o adaptador de comando Select.
                MySqlDataAdapter objAdaptador =
                    new MySqlDataAdapter();

                objAdaptador.SelectCommand = objComandoSQL;

                // Preenche o resultado executando o comando.
                objAdaptador.Fill(tblResultado);

                objAdaptador.Update(tblResultado);

                #endregion
            }
            finally
            {
                // Fecha a conex�o.
                Desconectar();
            }

            // Retorna o resultado.
            return tblResultado;
        }
        #endregion

        #region ConvertSqlToInt(string, SqlParameter[])
        /// <summary>
        /// Executa um comando SQL e retorna o
        /// n�mero de linhas afetadas.
        /// </summary>
        /// <param name="p_strComandoSQL">
        /// String contendo o comando SQL a ser executado.
        /// </param>
        /// <param name="p_arrParametros">
        /// Cole��o de par�metros utilizados pelo comando SQL.
        /// </param>
        /// <returns>
        /// N�mero de linhas afetadas pelo comando.
        /// </returns>
        public int ConvertSqlToInt(string p_strComandoSQL,
            params MySqlParameter[] p_arrParametros)
        {
            // Conecta ao banco.
            Conectar();

            // Cria vari�vel para armazenar as linhas afetadas.
            int intLinhasAfetadas = 0;

            try
            {
                #region Cria comando SQL

                // Instancia um comando SQL a ser executado.
                MySqlCommand objComandoSQL = new MySqlCommand();

                objComandoSQL.Connection = objConexao;
                objComandoSQL.CommandText = p_strComandoSQL;

                #endregion

                #region Adiciona par�metros ao comando
                // Verifica se existem par�metros.
                if (p_arrParametros != null)
                {
                    // Percorre cada par�metro recebido.
                    foreach (MySqlParameter objParametro
                        in p_arrParametros)
                    {
                        // Adiciona ao comando SQL.
                        objComandoSQL.Parameters.Add(
                            objParametro);
                    }
                }
                #endregion

                #region Executa o comando SQL
                // Executa o comando.
                intLinhasAfetadas = objComandoSQL.
                    ExecuteNonQuery();
                #endregion
            }
            finally
            {
                // Fecha a conex�o.
                Desconectar();
             }

            // Retorna o n�mero de linhas afetadas.
            return intLinhasAfetadas;
        }
        #endregion

        #endregion

       
    }
}