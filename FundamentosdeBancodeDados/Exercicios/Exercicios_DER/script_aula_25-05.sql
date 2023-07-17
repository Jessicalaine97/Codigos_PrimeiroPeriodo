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
);

/*Adicionando uma coluna na tabela aluno*/
alter table aluno add filiacao varchar(100);

/*Adicionar a coluna CH a tabela curso*/
alter table curso add column ch int;

/*Eliminar a coluna endereço da tabela aluno*/
alter table aluno drop endereco;

/*Adicionando a chave primária de curso*/
alter table curso add constraint pk_curso primary key(codigo);

/*Adicionando a chave primária da tabela aluno*/
alter table aluno add primary key(matricula);
/*Descrição da tabela aluno*/
desc aluno;

/*Adicionando a chave estrangeira da tabela aluno*/
alter table aluno add foreign key(codCurso) references
curso(codigo);

desc aluno;
/*Eliminando a chave estrangeira para criá-la com nome*/
alter table aluno drop foreign key aluno_ibfk_1;

/*Criando a chave estrangeira com o nome*/
alter table aluno add constraint fk_aluno_curso 
foreign key(codcurso) references curso(codigo);

/*Adicionando a coluna gênero na tabela aluno*/
alter table aluno add genero char(1);

/*Adicionando um valor padrão*/
alter table aluno alter genero set default 'M';

desc aluno;

/*Alterando o tipo do atributo nome para varchar de 80 - modify altera do o tipo*/
alter table aluno modify nome varchar(80);

/*Alterando o nome e o tipo da coluna filiacao para nome_pais e varchar de 80 - change altera nome e tipo*/
alter table aluno change filiacao nome_pais varchar(90);

/*Alterando o nome da coluna nome para nome_aluno*/
alter table aluno change nome nome_aluno varchar(80);

/*Alterando o tipo da coluna CPF para inteiro (ruim)*/
alter table aluno change cpf cpf int;

/*Eliminando a coluna nome_pais*/
alter table aluno drop column nome_pais;

/*Renomeando a tabela aluno para estudante*/
alter table aluno rename to estudante;





