/*DATABASE*/
create database iAxxMES;
use iAxxMES;

/*CREATE TABLES*/

CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cargo ENUM('master', 'admin', 'operator') NOT NULL,
    horario ENUM('manha', 'tarde', 'noite') NOT NULL,
    cpf VARCHAR(11) NOT NULL UNIQUE
);

CREATE TABLE maquina (
    id INT AUTO_INCREMENT PRIMARY KEY,
    apelido VARCHAR(50) NOT NULL,
    finura INT(4) NOT NULL,
    diametro DECIMAL(6,2) NOT NULL,
    numero_alimentadores INT(4) NOT NULL
);

CREATE TABLE maquina_dados (
    id INT AUTO_INCREMENT PRIMARY KEY,
    maquina_id INT NOT NULL,
    rpm INT(4) NOT NULL,
    status ENUM('ligado', 'desligado', 'alarme') NOT NULL,
    motivo_desligamento VARCHAR(255),
    data_hora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP(),
    FOREIGN KEY (maquina_id) REFERENCES maquina(id)
);

/*INSERTS*/

INSERT INTO usuario (nome, cargo, horario, cpf)
VALUES ('João Silva', 'master', 'manha', '12345678901'),
       ('Maria Santos', 'admin', 'tarde', '23456789012'),
       ('Pedro Oliveira', 'operator', 'noite', '34567890123');
       
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores)
VALUES ('Maquina A', 24, 1.25, 12),
       ('Maquina B', 28, 1.30, 10),
       ('Maquina C', 26, 1.35, 14),
       ('Maquina D', 30, 1.40, 11),
       ('Maquina E', 24, 1.50, 13),
       ('Maquina F', 28, 1.45, 9),
       ('Maquina G', 26, 1.60, 8),
       ('Maquina H', 30, 1.70, 7),
       ('Maquina I', 24, 1.75, 6),
       ('Maquina J', 28, 1.80, 5);

INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento)
VALUES (1, 1500, 'ligado', NULL),
       (2, 1400, 'desligado', 'Manutenção programada'),
       (3, 1600, 'alarme', 'Superaquecimento'),
       (4, 1550, 'ligado', NULL),
       (5, 1300, 'desligado', 'Falta de material'),
       (6, 1450, 'ligado', NULL),
       (7, 1700, 'ligado', NULL),
       (8, 1350, 'alarme', 'Falha elétrica'),
       (9, 1500, 'desligado', 'Manutenção corretiva'),
       (10, 1650, 'ligado', NULL);
