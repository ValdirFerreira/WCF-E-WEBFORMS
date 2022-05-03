CREATE DATABASE dbTesteGTI
go
USE dbTesteGTI


CREATE TABLE tblCliente
(
Id INT PRIMARY KEY IDENTITY(1,1),
CPF VARCHAR(50),
Nome VARCHAR(150),
RG VARCHAR(50),
DataExpedicao DateTime,
OrgaoExpedicao VARCHAR(80),
UF_Expedicao VARCHAR(10),
DataNascimento DateTime,
Sexo VARCHAR(10),
EstadoCivil VARCHAR(30),
CEP VARCHAR(50),
Logradouro VARCHAR(255),
Numero VARCHAR(10),
Complemento VARCHAR(255),
Bairro VARCHAR(150),
Cidade VARCHAR(255),
UF VARCHAR(10),
)