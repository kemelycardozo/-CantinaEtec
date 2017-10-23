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
    funcao VARCHAR(15) NOT NULL
);

create table Produto
(
	id_produto INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(45) NOT NULL,
    categoria VARCHAR (30) NOT NULL,
    valor DOUBLE NOT NULL
);

create table Venda
(
	id_venda INT PRIMARY KEY AUTO_INCREMENT,
    cpf VARCHAR(11),
    valor DOUBLE NOT NULL,
    data DATE NOT NULL,
    FOREIGN KEY (cpf) REFERENCES Cliente(cpf)
);

create table Produto_Venda
(
	id_produto INT,
    id_venda INT,
    FOREIGN KEY (id_produto) REFERENCES Produto(id_produto),
    FOREIGN KEY (id_venda) REFERENCES Venda(id_venda)
);

create table Recarga
(
	id_recarga INT PRIMARY KEY AUTO_INCREMENT,
    valor DOUBLE NOT NULL,
    data DATE NOT NULL,
    cpf VARCHAR(14),
    FOREIGN KEY (cpf) REFERENCES Cliente(cpf)
);

create table Lancamento
(
	id_lancamento INT PRIMARY KEY AUTO_INCREMENT,
    valor DOUBLE NOT NULL,
    data DATE NOT NULL,
    id_venda INT NOT NULL,
    id_recarga INT NOT NULL,
    FOREIGN KEY (id_venda) REFERENCES Venda(id_venda),
    FOREIGN KEY (id_recarga) REFERENCES Recarga(id_recarga)
);







 




