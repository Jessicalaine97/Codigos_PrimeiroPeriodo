create database faculdade;
use faculdade;
create table curso(
	codigo decimal(5),
	nome varchar(60)
);
create table aluno(
	matricula decimal(4),
	nome varchar (60),
	cpf decimal(11),
	datanasc date,
	endereco varchar(80), 
	codCurso decimal(5)
);
drop database faculdade;
create database faculdade;
use faculdade;
create table curso(
	codigo decimal(5),
	nome varchar(60)
);
create table aluno(
	matricula decimal(4),
	nome varchar (60),
	cpf decimal(11),
	datanasc date,
	endereco varchar(80), 
	codCurso decimal(5)
);

/*Adicionando uma coluna na tabela aluno e curso:*/
alter table aluno add fliliacao varchar(100);
alter table curso add CH int;

/*Eliminar a coluna endereço da tabela aluno:*/
alter table aluno drop endereco;

/*Adicionando a chave primaria de curso e aluno (2 formas de fazer -> se emitir o constraint o SGBD dá o nome automaticamente pra pk):*/
alter table curso add constraint pK_curso primary key(codigo);
alter table aluno add primary key(matricula);

/*Descrição da tabela aluno:*/
desc aluno;

/*Adicionando a chave estrangeira da tabela aluno:*/
alter table aluno add foreign key(codCurso) references curso(codigo);
desc aluno;

/*Eliminando a chave estrangeira para cria-la com nome:*/
alter table aluno drop foreign key aluno_ibfk_1;

/*Criando a chave estrangeira com o nome:*/
alter table aluno add constraint fk_aluno_curso foreign key(codCurso) references curso(codigo);

/*Add a coluna genero na tabela aluno:*/
alter table aluno add gerero char(1);
alter table aluno alter genero set default 'M';
desc aluno;
