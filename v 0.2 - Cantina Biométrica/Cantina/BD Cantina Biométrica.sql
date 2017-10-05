create database CantinaBiometrica;
use CantinaBiometrica;

create table Cliente
(
    cpf VARCHAR(14) PRIMARY KEY,
    rg VARCHAR(12) NOT NULL,
    nome VARCHAR(60) NOT NULL,
    datanasc VARCHAR(10) NOT NULL,
    endereco VARCHAR(50) NOT NULL,
    numero VARCHAR (7) NOT NULL, 
    bairro VARCHAR (45) NOT NULL,
    complemento VARCHAR (50),
    cidade VARCHAR (15) NOT NULL,
    cep VARCHAR(9) NOT NULL,
    telefone VARCHAR (14) NOT NULL,
    celular VARCHAR (15) NOT NULL,
    cargo VARCHAR(11) NOT NULL
);


create table Produto
(
	id_produto DECIMAL PRIMARY KEY,
    nome VARCHAR(45) NOT NULL,
    categoria VARCHAR (30) NOT NULL,
    valor DECIMAL(4,2) NOT NULL
);

create table Venda
(
	id_venda INT PRIMARY KEY,
    cliente_cpf VARCHAR(11)
);

create table Produto_Venda
(
	id_produto DECIMAL,
    id_venda INT,
    FOREIGN KEY (id_produto) REFERENCES Produto(id_produto),
    FOREIGN KEY (id_venda) REFERENCES Venda(id_venda)
);

select * from Cliente;



 




