CREATE TABLE AdminLogin
(
 UserName Nvarchar(20) NOT NULL,
 Pass Nvarchar(20) NOT NULL,
)

INSERT INTO AdminLogin (Username, Pass) 
VALUES 
('Comeau', '1111'),
('Perez','2222'),
('Babcock','3333')

Select * from AdminLogin