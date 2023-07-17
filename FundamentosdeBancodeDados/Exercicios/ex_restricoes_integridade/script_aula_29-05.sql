create database faculdade;
use faculdade;
create table curso(
	codigo decimal(5),
    nome varchar(60)
);
create table aluno(
	matricula decimal(4),
    nome varchar(50),
    cpf decimal(11),
    datanasc date,
    endereco varchar(80),
    codCurso decimal(5)
    /*se for criar uma chave primaria composta: primary key(matricula, nome);*/
    /*se quiser dar nome: constraint pk_aluno primary key(matricula, nome);*/
);
desc aluno;

alter table aluno modify nome varchar(50) not null,
				  modify datanasc date not null,
                  modify endereco varchar(80) not null;

desc aluno;

alter table aluno add cidade varchar(30);
alter table aluno modify cidade varchar(30) default 'Juiz de Fora';

desc aluno;
/*Inserindo um novo aluno sem colocar a cidade(completa altomaticamente com Juiz de Fora)*/
insert into aluno(matricula, nome, cpf, datanasc, endereco, codcurso) values(1234, 'Ana', '12345678978', '1997-12-12', 'Rua A', 222);

/*Criando a chave primaria (2 jeitos de fazer: criando nome ou nao):*/
alter table aluno add constraint pk_aluno primary key(matricula);
alter table curso add primary key(codigo);

desc curso;

/*Utilizando cpf como chave alternativa (SGBD deu o nome de cpf e pode ficar confuso):*/
alter table aluno add unique(cpf);

desc aluno;

/*Eliminando a chave canditada de nome cpf*/
alter table aluno drop index cpf;

/*Craindo a chave candidata com o nome ck_cpf*/
alter table aluno add constraint ck_cpf unique(cpf);

desc aluno;

/*Craindo a coluna salario na tabela aluno*/
alter table aluno add salario decimal(7,2);

/*Adicionando a restrição:*/
alter table aluno add check (salario>0);
/*Se quisesse por valor max e min: salario>0 and salario<1000*/
/*Se quisesse por nome: alter table aluno add constraint verifica_salario check (salario>0)*/

/*Adicionandoo curso 222 de ADS*/
insert into curso values(222, 'Análise e Desenvolvimento de Sistemas');

/*Adicionando a chave estrangeira da tabela aluno*/
alter table aluno add foreign key(codCurso) references curso(codigo) on delete cascade on update cascade;

