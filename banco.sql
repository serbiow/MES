/*DATABASE*/

create database iAxxMES;
use iAxxMES;

-- Garantias de privilégios
grant all privileges on iaxxmes.* to 'user'@'%' with grant option;
flush privileges;

/*CREATE TABLES*/

CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    nivel_permissao ENUM('master', 'admin', 'operator') NOT NULL,
    registro_matricula VARCHAR(10) NOT NULL UNIQUE
);

CREATE TABLE login (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT NOT NULL,
    login_nome VARCHAR(70) NOT NULL UNIQUE,
    senha VARCHAR(70) NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES usuario(id)
);

CREATE TABLE grupo (
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    descricao VARCHAR(255)
);

CREATE TABLE maquina (
    id INT AUTO_INCREMENT PRIMARY KEY,
    apelido VARCHAR(50) NOT NULL,
    finura INT(4) NOT NULL,
    diametro DECIMAL(6,2) NOT NULL,
    numero_alimentadores INT(4) NOT NULL
);

-- Tabela de associação grupo_maquina para representar a relação muitos-para-muitos
CREATE TABLE grupo_maquina (
    grupo_id INT,
    maquina_id INT,
    PRIMARY KEY (grupo_id, maquina_id),
    FOREIGN KEY (grupo_id) REFERENCES grupo(id) ON DELETE CASCADE,
    FOREIGN KEY (maquina_id) REFERENCES maquina(id) ON DELETE CASCADE
);

CREATE TABLE motivos_parada (
	id INT AUTO_INCREMENT PRIMARY KEY,
    descricao VARCHAR(255)
);

CREATE TABLE maquina_status (
	id INT AUTO_INCREMENT PRIMARY KEY,
    descricao VARCHAR(255)
);

CREATE TABLE maquina_dados (
    id INT AUTO_INCREMENT PRIMARY KEY,
    maquina_id INT NOT NULL,
    rpm INT(4) NOT NULL,
    status INT NOT NULL,
    motivo_parada INT,
    comentario VARCHAR(255),
    data_hora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP(),
    FOREIGN KEY (maquina_id) REFERENCES maquina(id),
    FOREIGN KEY (motivo_parada) REFERENCES motivos_parada(id),
    FOREIGN KEY (status) REFERENCES maquina_status(id)
);

/*INSERTS*/

INSERT INTO usuario (nome, nivel_permissao, registro_matricula)
VALUES ('João Silva', 'master', '1234567890'),
       ('Maria Santos', 'admin', '2345678901'),
       ('Pedro Oliveira', 'operator', '3456789012');
       
INSERT INTO login (usuario_id, login_nome, senha) 
VALUES (1, 'joao_master', 'd/yTvHDt8x3Qt0QA9f+kyKJqbsRmq+Mw1mNxjNub8BOmcvzQtTF3Djky3Ub59sFJ'), -- João Silva
       (2, 'maria_admin', 'p6AfVsR4wC7y0FbN3rd2e+s4CMelO0xvtsPe5Loffx8tNGdlZZmoMl3aBeBHNt/W'), -- Maria Santos
       (3, 'pedro_operator', 'nH7Ay/gMjZE3WSPw7QEGF8OVkVRsFOBmPb/NKiLDyzg2S3ATgf2rJzSwdHeuB+u0'); -- Pedro Oliveira

-- Inserts para tabela motivos_parada
INSERT INTO motivos_parada (descricao) VALUES ('Não apontada');
INSERT INTO motivos_parada (descricao) VALUES ('Fim de peça');
INSERT INTO motivos_parada (descricao) VALUES ('Quebra de lycra');
INSERT INTO motivos_parada (descricao) VALUES ('Quebra de fio');
INSERT INTO motivos_parada (descricao) VALUES ('Quebra de agulha');
INSERT INTO motivos_parada (descricao) VALUES ('Inspeção de defeito');
INSERT INTO motivos_parada (descricao) VALUES ('Outros');

-- Inserts para tabela maquina_status
INSERT INTO maquina_status (descricao) VALUES ('Rodando');
INSERT INTO maquina_status (descricao) VALUES ('Parada');
INSERT INTO maquina_status (descricao) VALUES ('Setup');
INSERT INTO maquina_status (descricao) VALUES ('Carga de fio');
INSERT INTO maquina_status (descricao) VALUES ('Sem programação');

-- Inserts para tabela grupo
INSERT INTO grupo (nome, descricao) VALUES ('Grupo 1', 'Descrição do Grupo 1');
INSERT INTO grupo (nome, descricao) VALUES ('Grupo 2', 'Descrição do Grupo 2');
INSERT INTO grupo (nome, descricao) VALUES ('Grupo 3', 'Descrição do Grupo 3');
INSERT INTO grupo (nome, descricao) VALUES ('Grupo 4', 'Descrição do Grupo 4');
INSERT INTO grupo (nome, descricao) VALUES ('Grupo 5', 'Descrição do Grupo 5');

-- Inserts para a tabela maquina
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_001', 121, 62.94, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_002', 109, 31.71, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_003', 95, 45.12, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_004', 90, 54.63, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_005', 123, 44.04, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_006', 115, 62.75, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_007', 135, 49.69, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_008', 147, 57.09, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_009', 55, 55.91, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_010', 52, 67.72, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_011', 84, 67.64, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_012', 90, 55.76, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_013', 102, 36.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_014', 103, 36.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_015', 104, 37.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_016', 100, 37.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_017', 101, 38.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_018', 102, 38.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_019', 103, 39.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_020', 104, 39.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_021', 100, 40.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_022', 101, 40.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_023', 102, 41.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_024', 103, 41.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_025', 104, 42.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_026', 100, 42.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_027', 101, 43.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_028', 102, 43.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_029', 103, 44.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_030', 104, 44.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_031', 100, 45.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_032', 101, 45.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_033', 102, 46.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_034', 103, 46.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_035', 104, 47.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_036', 100, 47.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_037', 101, 48.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_038', 102, 48.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_039', 103, 49.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_040', 104, 49.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_041', 100, 50.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_042', 101, 50.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_043', 102, 51.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_044', 103, 51.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_045', 104, 52.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_046', 100, 52.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_047', 101, 53.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_048', 102, 53.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_049', 103, 54.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_050', 104, 54.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_051', 100, 55.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_052', 101, 55.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_053', 102, 56.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_054', 103, 56.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_055', 104, 57.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_056', 100, 57.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_057', 101, 58.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_058', 102, 58.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_059', 103, 59.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_060', 104, 59.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_061', 100, 60.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_062', 101, 60.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_063', 102, 61.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_064', 103, 61.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_065', 104, 62.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_066', 100, 62.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_067', 101, 63.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_068', 102, 63.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_069', 103, 64.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_070', 104, 64.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_071', 100, 65.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_072', 101, 65.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_073', 102, 66.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_074', 103, 66.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_075', 104, 67.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_076', 100, 67.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_077', 101, 68.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_078', 102, 68.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_079', 103, 69.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_080', 104, 69.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_081', 100, 70.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_082', 101, 70.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_083', 102, 71.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_084', 103, 71.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_085', 104, 72.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_086', 100, 72.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_087', 101, 73.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_088', 102, 73.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_089', 103, 74.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_090', 104, 74.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_091', 100, 75.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_092', 101, 75.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_093', 102, 76.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_094', 103, 76.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_095', 104, 77.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_096', 100, 77.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_097', 101, 78.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_098', 102, 78.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_099', 103, 79.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_100', 104, 79.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_101', 100, 80.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_102', 101, 80.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_103', 102, 81.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_104', 103, 81.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_105', 104, 82.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_106', 100, 82.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_107', 101, 83.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_108', 102, 83.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_109', 103, 84.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_110', 104, 84.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_111', 100, 85.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_112', 101, 85.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_113', 102, 86.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_114', 103, 86.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_115', 104, 87.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_116', 100, 87.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_117', 101, 88.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_118', 102, 88.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_119', 103, 89.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_120', 104, 89.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_121', 100, 90.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_122', 101, 90.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_123', 102, 91.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_124', 103, 91.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_125', 104, 92.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_126', 100, 92.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_127', 101, 93.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_128', 102, 93.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_129', 103, 94.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_130', 104, 94.50, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_131', 100, 95.00, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_132', 101, 95.50, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_133', 102, 96.00, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_134', 103, 96.50, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_135', 104, 97.00, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_136', 100, 97.50, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_137', 101, 98.00, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_138', 102, 98.50, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_139', 103, 99.00, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_140', 104, 99.50, 10);

-- Inserts para a tabela maquina_dados
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (1, 99, 1, NULL, 'Comentário 1', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (2, 42, 1, NULL, 'Comentário 2', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (3, 0, 4, NULL, 'Comentário 3', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (4, 0, 3, NULL, 'Comentário 4', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (5, 0, 3, NULL, 'Comentário 5', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (6, 0, 4, NULL, 'Comentário 6', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (7, 0, 2, 3, 'Comentário 7', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (8, 1860, 1, NULL, 'Comentário 8', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (9, 0, 2, NULL, 'Comentário 9', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (10, 0, 2, 3, 'Comentário 10', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (11, 0, 4, NULL, 'Comentário 11', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (12, 0, 2, 4, 'Comentário 12', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (13, 0, 5, NULL, 'Comentário 13', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (14, 0, 4, NULL, 'Comentário 14', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (15, 0, 3, NULL, 'Comentário 15', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (16, 758, 1, NULL, 'Comentário 16', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (17, 0, 5, NULL, 'Comentário 17', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (18, 879, 1, NULL, 'Comentário 18', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (19, 1139, 1, NULL, 'Comentário 19', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (20, 0, 5, NULL, 'Comentário 20', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (21, 0, 3, NULL, 'Comentário 21', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (22, 0, 3, NULL, 'Comentário 22', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (23, 0, 2, 3, 'Comentário 23', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (24, 0, 4, NULL, 'Comentário 24', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (25, 0, 3, NULL, 'Comentário 25', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (26, 0, 2, 4, 'Comentário 26', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (27, 0, 3, NULL, 'Comentário 27', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (28, 0, 2, 4, 'Comentário 28', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (29, 0, 5, NULL, 'Comentário 29', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (30, 0, 3, NULL, 'Comentário 30', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (31, 0, 3, NULL, 'Comentário 31', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (32, 0, 2, 1, 'Comentário 32', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (33, 1733, 1, NULL, 'Comentário 33', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (34, 0, 3, NULL, 'Comentário 34', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (35, 0, 5, NULL, 'Comentário 35', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (36, 0, 5, NULL, 'Comentário 36', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (37, 961, 1, NULL, 'Comentário 37', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (38, 37, 1, NULL, 'Comentário 38', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (39, 0, 3, NULL, 'Comentário 39', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (40, 0, 4, NULL, 'Comentário 40', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (41, 0, 4, NULL, 'Comentário 41', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (42, 0, 5, NULL, 'Comentário 42', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (43, 0, 5, NULL, 'Comentário 43', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (44, 0, 2, 2, 'Comentário 44', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (45, 0, 5, NULL, 'Comentário 45', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (46, 0, 5, NULL, 'Comentário 46', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (47, 0, 2, 6, 'Comentário 47', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (48, 0, 5, NULL, 'Comentário 48', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (49, 0, 3, NULL, 'Comentário 49', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (50, 0, 2, 6, 'Comentário 50', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (51, 1416, 1, NULL, 'Comentário 51', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (52, 0, 2, 5, 'Comentário 52', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (53, 0, 3, NULL, 'Comentário 53', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (54, 0, 5, NULL, 'Comentário 54', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (55, 0, 2, 3, 'Comentário 55', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (56, 22, 1, NULL, 'Comentário 56', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (57, 0, 5, NULL, 'Comentário 57', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (58, 0, 3, NULL, 'Comentário 58', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (59, 0, 2, 4, 'Comentário 59', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (60, 1820, 1, NULL, 'Comentário 60', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (61, 0, 3, NULL, 'Comentário 61', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (62, 1747, 1, NULL, 'Comentário 62', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (63, 0, 5, NULL, 'Comentário 63', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (64, 1264, 1, NULL, 'Comentário 64', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (65, 0, 5, NULL, 'Comentário 65', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (66, 0, 4, NULL, 'Comentário 66', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (67, 670, 1, NULL, 'Comentário 67', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (68, 0, 5, NULL, 'Comentário 68', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (69, 0, 3, NULL, 'Comentário 69', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (70, 0, 4, NULL, 'Comentário 70', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (71, 832, 1, NULL, 'Comentário 71', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (72, 72, 1, NULL, 'Comentário 72', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (73, 0, 4, NULL, 'Comentário 73', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (74, 0, 4, NULL, 'Comentário 74', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (75, 0, 5, NULL, 'Comentário 75', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (76, 0, 4, NULL, 'Comentário 76', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (77, 0, 2, 2, 'Comentário 77', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (78, 0, 4, NULL, 'Comentário 78', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (79, 0, 2, 6, 'Comentário 79', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (80, 41, 1, NULL, 'Comentário 80', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (81, 851, 1, NULL, 'Comentário 81', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (82, 0, 4, NULL, 'Comentário 82', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (83, 0, 4, NULL, 'Comentário 83', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (84, 0, 2, 3, 'Comentário 84', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (85, 1285, 1, NULL, 'Comentário 85', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (86, 1175, 1, NULL, 'Comentário 86', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (87, 0, 4, NULL, 'Comentário 87', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (88, 0, 2, 5, 'Comentário 88', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (89, 0, 3, NULL, 'Comentário 89', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (90, 1367, 1, NULL, 'Comentário 90', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (91, 0, 2, 6, 'Comentário 91', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (92, 0, 2, 5, 'Comentário 92', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (93, 0, 3, NULL, 'Comentário 93', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (94, 0, 2, 2, 'Comentário 94', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (95, 55, 1, NULL, 'Comentário 95', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (96, 0, 5, NULL, 'Comentário 96', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (97, 0, 3, NULL, 'Comentário 97', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (98, 0, 4, NULL, 'Comentário 98', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (99, 0, 4, NULL, 'Comentário 99', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (100, 0, 5, NULL, 'Comentário 100', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (101, 0, 2, 3, 'Comentário 101', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (102, 0, 3, NULL, 'Comentário 102', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (103, 1182, 1, NULL, 'Comentário 103', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (104, 0, 5, NULL, 'Comentário 104', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (105, 1916, 1, NULL, 'Comentário 105', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (106, 0, 3, NULL, 'Comentário 106', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (107, 958, 1, NULL, 'Comentário 107', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (108, 0, 4, NULL, 'Comentário 108', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (109, 0, 3, NULL, 'Comentário 109', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (110, 0, 5, NULL, 'Comentário 110', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (111, 0, 2, 5, 'Comentário 111', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (112, 564, 1, NULL, 'Comentário 112', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (113, 867, 1, NULL, 'Comentário 113', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (114, 0, 3, NULL, 'Comentário 114', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (115, 0, 5, NULL, 'Comentário 115', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (116, 0, 2, 1, 'Comentário 116', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (117, 0, 2, 1, 'Comentário 117', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (118, 1877, 1, NULL, 'Comentário 118', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (119, 0, 4, NULL, 'Comentário 119', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (120, 0, 3, NULL, 'Comentário 120', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (121, 0, 5, NULL, 'Comentário 121', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (122, 43, 1, NULL, 'Comentário 122', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (123, 0, 2, 6, 'Comentário 123', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (124, 0, 2, 1, 'Comentário 124', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (125, 0, 5, NULL, 'Comentário 125', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (126, 0, 2, 3, 'Comentário 126', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (127, 1764, 1, NULL, 'Comentário 127', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (128, 0, 4, NULL, 'Comentário 128', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (129, 0, 3, NULL, 'Comentário 129', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (130, 0, 3, NULL, 'Comentário 130', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (131, 0, 5, NULL, 'Comentário 131', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (132, 0, 4, NULL, 'Comentário 132', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (133, 0, 2, 6, 'Comentário 133', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (134, 1333, 1, NULL, 'Comentário 134', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (135, 1932, 1, NULL, 'Comentário 135', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (136, 0, 2, 5, 'Comentário 136', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (137, 0, 2, 2, 'Comentário 137', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (138, 0, 3, NULL, 'Comentário 138', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (139, 1024, 1, NULL, 'Comentário 139', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (140, 0, 2, 6, 'Comentário 140', NOW());

-- Inserts para a tabela grupo_maquina
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 1);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 2);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 3);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 4);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 5);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 6);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 7);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 8);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 9);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 10);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 11);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 12);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 13);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 14);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 15);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 16);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 17);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 18);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 19);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 20);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 21);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 22);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 23);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 24);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 25);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 26);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 27);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 28);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 29);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 30);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 31);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 32);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 33);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 34);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 35);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 36);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 37);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 38);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 39);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 40);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 41);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 42);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 43);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 44);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 45);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 46);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 47);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 48);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 49);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 50);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 51);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 52);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 53);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 54);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 55);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 56);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 57);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 58);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 59);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 60);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 61);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 62);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 63);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 64);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 65);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 66);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 67);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 68);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 69);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 70);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 71);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 72);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 73);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 74);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 75);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 76);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 77);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 78);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 79);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 80);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 81);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 82);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 83);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 84);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 85);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 86);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 87);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 88);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 89);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 90);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 91);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 92);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 93);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 94);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 95);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 96);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 97);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 98);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 99);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 100);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 101);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 102);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 103);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 104);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 105);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 106);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 107);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 108);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 109);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 110);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 111);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 112);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 113);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 114);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 115);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 116);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 117);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 118);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 119);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 120);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 121);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 122);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 123);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 124);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 125);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 126);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 127);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 128);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 129);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 130);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 131);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 132);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 133);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 134);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 135);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (2, 136);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (3, 137);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (4, 138);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (5, 139);
INSERT INTO grupo_maquina (grupo_id, maquina_id) VALUES (1, 140);