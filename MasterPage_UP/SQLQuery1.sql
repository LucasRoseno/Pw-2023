create database Teste2
go
use Teste2
go
create table contatos2(
id int primary key identity,
nome varchar(80),
fone varchar(20)
)

insert into contatos2 values('Aluno1','111111')
insert into contatos2 values('Aluno2','222222')
insert into contatos2 values('Aluno3','333333')
insert into contatos2 values('Aluno4','444444')
insert into contatos2 values('Aluno5','555555')

select * from contatos2
create table relatorio
(
	id int primary key identity,
	clube char(50),
	titulos int, 
	continente char(20),
	pais char(30)
)
insert into relatorio values('Real Madrid', 28, 'Europa', 'Espanha')
insert into relatorio values('Boca Juniors', 18, 'América do Sul', 'Argentina')
insert into relatorio values('Independiente',18, 'América do Sul', 'Argentina')
insert into relatorio values('Mlian', 18, 'Europa', 'Itália')
insert into relatorio values('Barcelona', 17, 'Europa', 'Espanha')
insert into relatorio values('São Paulo', 12, 'América do Sul', 'Brasil')
insert into relatorio values('River Plate', 12,'América do Sul', 'Argentina')
insert into relatorio values('Ajax', 10, 'Europa', 'Holanda')
insert into relatorio values('Peñarol',  9, 'América do Sul', 'Uruguai')
insert into relatorio values('Nacional', 9, 'América do Sul', 'Uruguai')
insert into relatorio values('Santos', 8, 'América do Sul', 'Brasil')
insert into relatorio values('Man United', 8, 'Europa', 'Inglaterra')

Select clube, titulos from relatorio  where continente = 'Europa'

Select clube, titulos from relatorio  where continente = 'América do Sul'
 

 go
create table contatosIMG
(
	id int primary key identity(1,1),
	nome varchar(50),
	fone varchar(20),
	img varbinary(max)
)


go
select * from contatosIMG
