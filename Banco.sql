USE master;

CREATE DATABASE ProjetoLC;



USE ProjetoLC;

CREATE TABLE Pessoa (
idPessoa INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(200) NOT NULL,
email VARCHAR(150) NOT NULL,
userName VARCHAR(100) NOT NULL,
senha VARCHAR(100) NOT NULL,
cargo VARCHAR(50) NOT NULL,
dtNascimento DATE NOT NULL,
sexo VARCHAR(15) NOT NULL,
telFixo VARCHAR(10) NULL,
telCelular VARCHAR(11) NULL,
statusPessoa VARCHAR(10) DEFAULT 'ativo',
RG VARCHAR(25) NOT NULL,
CPF VARCHAR(11) NOT NULL);

INSERT INTO Pessoa (
nome,
email,
userName ,
senha ,
cargo ,
dtNascimento,
sexo ,
telFixo,
telCelular,
statusPessoa,
RG ,
CPF  

) 
values ('cleonice lima',
'cleonicelima@etec.com', 
'cleo', 
'12345678',
'admistrador',
'1977-08-17',
'feminino',
'1123456789',
'11987654321',
'ativo',
'27786034',
'18556198813'
);
select * from Pessoa;

CREATE TABLE Produto (
idProd INT PRIMARY KEY IDENTITY(1,1),
codBarra VARCHAR(13) NOT NULL,
loteProd VARCHAR(9) NOT NULL,
valProd VARCHAR(10) NULL,
nomeProd VARCHAR(200) NOT NULL,
descProd VARCHAR(200) NOT NULL,
qtdProd INT NOT NULL,
precoProd FLOAT(10) NOT NULL,
medProd VARCHAR(10) NOT NULL
);
SELECT * FROM Produto

INSERT INTO Produto
(
    codBarra,
    loteProd,
    valProd,
    nomeProd,
    descProd,
    qtdProd,
    precoProd,
    medProd
)
VALUES
(   '990000001177',  -- codBarra - varchar(13)
    '12345FR',  -- loteProd - varchar(9)
    '022022',  -- valProd - varchar(10)
    'COLONIA 100ML',  -- nomeProd - varchar(200)
    'FRAGANCIA FLORAL',  -- descProd - varchar(200)
    2,   -- qtdProd - int
    109.90, -- precoProd - real
    'UNIDADE'   -- medProd - varchar(10)
);

