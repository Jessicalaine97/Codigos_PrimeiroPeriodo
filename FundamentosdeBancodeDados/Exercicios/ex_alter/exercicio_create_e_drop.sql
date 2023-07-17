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
alter table EMPREGADO add cpf char(11);
alter table EMPREGADO modify NOME varchar(15);
alter table EMPREGADO add sobrenome varchar(15);
alter table EMPREGADO modify CODIGO_CARGO decimal(3);
alter table EMPREGADO add CODIGO_DEP decimal(3);
alter table EMPREGADO modify CODIGO_CARGO decimal not null;

/*Opção: alter table EMPREGADO (add cpf char(11),*/
/*                             modify NOME varchar(15),*/
/*                             add sobrenome varchar(15),*/
/*                             modify CODIGO_CARGO decimal(3),*/
/*                             add CODIGO_DEP decimal(3));*/

/*nao pode mudar a msm variavel no msm comando (ja esta na 48 nao pode estar no msm comando): encerrar esse e escrever o codigo da 43*/

/*alter table EMPREGADO modify CODIGO_CARGO decimal not null;*/

/*column opcional*/
alter table CARGO drop column DESCRICAO_CARGO;
alter table CARGO add NOME_CARGO varchar(40);

alter table DEPARTAMENTO add LOCAL varchar(20);

/*na verdade é decimal(6): ao inves de char: msm tipo que tinha antes*/
alter table DEPENDENTE modify CODIGO_EMPREGADO char not null;
