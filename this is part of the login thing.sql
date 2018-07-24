use sandboxlogintest

CREATE TABLE AdminLogin
(
 UserName Nvarchar(20) NOT NULL,
 Pass Varchar(255) NOT NULL,
)

INSERT INTO AdminLogin (Username, Pass) 
VALUES 
('Comeau', 'B59C67BF196A4758191E42F76670CEBA'),
('Perez', '934B535800B1CBA8F96A5D72F72F1611'),
('Babcock', '2BE9BD7A3434F7038CA27D1918DE58BD')

Select * from AdminLogin

go
Create PROC [dbo].[PasswordCheck]
as
begin 
select * from adminlogin
end

--(SELECT HASHBYTES('Md5', '3333'))
