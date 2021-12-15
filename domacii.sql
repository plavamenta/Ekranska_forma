CREATE DATABASE Pesme
USE Pesme
create table pesma(
    id int identity(0,1),
    naziv nvarchar(30),
    izvodjac nvarchar(30),
    trajanje nvarchar(15),
    jezik nvarchar(30)
)
insert into pesma
values
('Pumpkin','The Regrettes','207','Engleski jezik'),
('Pola pet','Buc Kesidi','182','Srpski jezik'),
('Mirno idem krivim putem','Brano Likic','186','Srpski jezik')