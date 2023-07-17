create database empresa;
use empresa;
create table EMPREGADO (
	CODIGO_EMPREGADO decimal (6) primary key,
    NOME varchar (50),
    CODIGO_CARGO decimal (3),
    ENDERECO varchar (50),
    BAIRRO varchar (20),
    CIDADE varchar (20),
    CODIGO_CHEFE decimal (6),
    UF char (2),
    DATA_NASC date,
    SEXO char (1),
    FILIACAO varchar (60),
    SALARIO decimal (10, 2)
);
create table CARGO (
	CODIGO_CARGO decimal (3) primary key,
    DESCRICAO_CARGO varchar (30),
    SALARIO_MIN decimal (7, 2),
    SALARIO_MAX decimal (8, 2),
    NIVEL_GRADUACAO char (1)
);
create table DEPENDENTE (
	CODIGO_EMPREGADO char (6) primary key,
    NOME_DEPENDENTE varchar (50),
    SEXO char (1),
    DATA_NASC date,
    PARENTESCO varchar (15)
);
create table DEPARTAMENTO(
	CODIGO_DEP decimal (3) primary key,
    NOME_DEP varchar (30),
    CODIGO_GERENTE decimal (6),
    DATA_INICIO_GERENTE date,
    DATA_CRIACAO date
);