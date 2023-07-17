create database fornecedor;
use fornecedor;
CREATE TABLE fornecedor (
    num_fornecedor NUMERIC(4) PRIMARY KEY,
    fnome VARCHAR(30),
    status_forn VARCHAR(15),
    cidade VARCHAR(20),
    CHECK (status_forn = 'disponível'
        OR status_forn = 'indisponível')
);
CREATE TABLE peca (
    num_peca NUMERIC(5) PRIMARY KEY,
    pnome VARCHAR(30),
    cor VARCHAR(10),
    peso FLOAT,
    cidade VARCHAR(20),
    preco FLOAT
);
CREATE TABLE pedido (
    num_fornecedor NUMERIC(4),
    num_peca NUMERIC(5),
    qdade INT,
    CONSTRAINT pk_pedido PRIMARY KEY (num_fornecedor , num_peca),
    CONSTRAINT fk_forn_ped FOREIGN KEY (num_fornecedor)
        REFERENCES fornecedor (num_fornecedor),
    CONSTRAINT fk_peca_ped FOREIGN KEY (num_peca)
        REFERENCES peca (num_peca)
);

insert into fornecedor values(1, 'Agnaldo', 'disponível', 'São Paulo');
/*Quando quero omitir um dado, nesse caso cidade*/
insert into fornecedor(num_fornecedor, fnome, status_forn) values(2, 'Ronaldo', 'indisponível');
/*Quando quero inserir varios dados de uma vez(1 insert)*/
insert into fornecedor  values
(3, 'Lula', 'Indisponível', 'Rio de Janeiro'),
(4, 'Lisa', 'Indisponível', 'Belo Horizonte'),
(5, 'Mauro', 'Disponível', 'Juiz de Fora');

insert into peca values
(1, 'Porca', 'Vermelho', 0.8, 'São Paulo', 1.75),
(2, 'Parafuso', 'Verde', 1.50, 'Belo Horizonte', 2.0),
(3, 'Tubo', 'Branco', 1.99,  'Juiz de Fora', 7.0);

insert into pedido values
(1,1,300),
(1,2,200), 
(1,3,50), 
(1,4,100),
(1,5,20), 
(1,6,68), 
(4,1,500),
(4,2,400),
(5,3,450);