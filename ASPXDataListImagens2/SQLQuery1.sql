create database Teste

use Teste

create table contatos
(
	id int primary key identity(1,1),
	nome varchar(50),
	fone varchar(20)
)

insert into contatos values('Rubens','1111')
insert into contatos values('Paula','2222')
insert into contatos values('ETESP','3333')

select * from contatos
