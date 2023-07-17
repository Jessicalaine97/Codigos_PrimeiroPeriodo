/*Criando a tabela locação*/
CREATE TABLE locacao (
    codigo_locacao DECIMAL(5),
    codigo_cliente DECIMAL(4),
    codigo_filme DECIMAL(3),
    valor REAL(5 , 2 ),
    data_locacao DATE
);
/*Criando a chave primária da tabela locacao*/
alter table locacao add primary key(codigo_locacao);

/*Cliente*/
/*o	Altere o atributo rua para endereço do tipo varchar(70);
o	Elimine os atributos bairro, cidade e cep.
o	O atributo cpf deverá ser chave candidata.
o	O atributo datanasc não poderá ter o valor nulo.
*/

alter table cliente change rua endereco varchar(70),
drop bairro,
drop cidade,
drop cep,
add unique(cpf),
modify datanasc date not null;

desc cliente;

/*Filme*/
/*o	O atributo duracao não poderá receber o valor nulo.
o	O atributo estreia deverá ter o valor padrão ‘2022-01-01’.
*/
alter table filme modify duracao decimal(5) not null,
alter estreia set default '2022-01-01';

desc filme;

/*diretor*/
/*o	O atributo nome_diretor não poderá receber o valor nulo.
o	Adicione os atributos rua, bairro,cidade,cep,cpf e 
telefone com o tipo que achar mais apropriado.
*/
alter table diretor 
change nome_diretor nome_diretor varchar(50) not null,
add rua varchar(50),
add bairro varchar(20),
add cidade varchar(30),
add cep varchar(15),
add cpf decimal(11),
add telefone varchar(20);

desc diretor;

/*Gênero*/
/*o	O atributo nome_genero deverá ser do tipo varchar(30) 
e o deverá receber o valor padrão comédia.	*/
alter table genero modify nome_genero varchar(30) 
default 'Comédia';

desc genero;

/*Locacao*/
/*o	Adicione o atributo data_entrega do tipo data.*/
alter table locacao add data_entrega date;

/*Inserções na tabela locação*/
insert into locacao values
(1,1111,300,5,'2016-05-01','2016-05-03'),
(2,1111,310,5.50,'2016-05-09','2016-05-19'),
(3,1111,320,5.3,'2016-04-22','2016-04-28'),
(4,1212,301,6.80,'2016-03-10','2016-03-15'),
(5,1212,302,5.7,'2016-03-12','2016-03-17'),
(6,1313,321,7,'2016-06-13','2016-06-18');

/*Criando as chaves estrangeiras*/
alter table locacao add constraint fk_locacao_cliente
foreign key(codigo_cliente) references cliente(codigo_cliente)
on delete cascade on update cascade,
add constraint fk_locacao_filme foreign key(codigo_filme)
references filme(codigo_filme) on delete cascade on update
cascade;
desc locacao;

