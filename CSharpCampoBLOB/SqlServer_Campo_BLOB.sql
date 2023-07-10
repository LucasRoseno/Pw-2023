create database Teste

use Teste

create table contatosIMG
(
	id int primary key identity(1,1),
	nome varchar(50),
	fone varchar(20),
	img varbinary(max)
)
create table relatorio
(
	id int primary key identity,
	MES varchar(60),
	VALOR int
)
insert into relatorio values('Março',200)
insert into relatorio values('Abril',100)
insert into relatorio values('Maio',800)

select * from contatosIMG
select * from contatos
select * from relatorio