CREATE DATABASE Empresa;

USE Empresa;

CREATE TABLE dadosEmpresa(
	id_emp INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    razao_social VARCHAR(250) NOT NULL,
    nome_fantasia VARCHAR(250) NOT NULL,
    cnpj VARCHAR(250) NOT NULL UNIQUE,
    inscricao_estadual VARCHAR(250),
    telefone VARCHAR(250) NOT NULL,
    email VARCHAR(250) NOT NULL,
    cidade VARCHAR(250) NOT NULL,
    estado VARCHAR(250) NOT NULL,
    cep VARCHAR(250) NOT NULL,
    data_cadastro DATETIME NOT NULL
);

SELECT * FROM dadosEmpresa;

INSERT INTO dadosEmpresa 
(razao_social, nome_fantasia, cnpj, inscricao_estadual, telefone, email, cidade, estado, cep, data_cadastro) 
VALUES
('Comércio de Alimentos LTDA', 'Supermercado Bom Preço', '12.345.678/0001-99', '1234567890', '(69) 99999-1111', 'contato@bompreco.com', 'Ji-Paraná', 'RO', '76900-000', '2025-09-23 14:30:00'),

('Tech Solutions LTDA', 'Tech Soluções', '98.765.432/0001-55', '9876543210', '(69) 98888-2222', 'suporte@techsolucoes.com', 'Porto Velho', 'RO', '76800-000', '2025-09-23 15:00:00'),

('Agropecuária Brasil S/A', 'AgroBrasil', '11.222.333/0001-44', '1122334455', '(69) 97777-3333', 'agro@agrobrasil.com', 'Cacoal', 'RO', '76960-000', '2025-09-23 16:10:00');
