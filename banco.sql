CREATE DATABASE banco;
use banco;
CREATE TABLE preagendamento(
    nome    VARCHAR (50) NOT NULL,
    telefone    VARCHAR (15) NOT NULL,
    dia DATE NOT NULL,
    animal  VARCHAR (15) NOT NULL,
    necessidade VARCHAR(90) NOT NULL
);

insert into preagendamento(nome, telefone, dia, animal, necessidade) values
("Daniel", "123456789", "30-10-2021", "cachorro", "banho e tosa")

select * from preagendamento