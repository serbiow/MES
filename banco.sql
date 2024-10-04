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

CREATE TABLE maquina (
    id INT AUTO_INCREMENT PRIMARY KEY,
    apelido VARCHAR(50) NOT NULL,
    finura INT(4) NOT NULL,
    diametro DECIMAL(6,2) NOT NULL,
    numero_alimentadores INT(4) NOT NULL,
    grupo ENUM('Grupo 1', 'Grupo 2', 'Grupo 3', 'Grupo 4', 'Grupo 5') NOT NULL
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

-- Select para as os dados mais atualizados de cada máquina
-- TODO: ajeitar esse insert
SELECT m.id, m.apelido, m.grupo, md.rpm, ms.descricao AS status, mp.descricao AS motivo_parada, md.comentario
FROM maquina m
JOIN (
    SELECT maquina_id, MAX(data_hora) AS max_data_hora
    FROM maquina_dados
    GROUP BY maquina_id
) md_recent ON m.id = md_recent.maquina_id
JOIN maquina_dados md ON m.id = md.maquina_id AND md.data_hora = md_recent.max_data_hora
LEFT JOIN maquina_status ms ON md.status = ms.id
LEFT JOIN motivos_parada mp ON md.motivo_parada = mp.id
ORDER BY m.apelido;

/*INSERTS*/

INSERT INTO usuario (nome, nivel_permissao, registro_matricula)
VALUES ('João Silva', 'master', '1234567890'),
       ('Maria Santos', 'admin', '2345678901'),
       ('Pedro Oliveira', 'operator', '3456789012');
       
INSERT INTO login (usuario_id, login_nome, senha) 
VALUES (1, 'joao_master', 'd/yTvHDt8x3Qt0QA9f+kyKJqbsRmq+Mw1mNxjNub8BOmcvzQtTF3Djky3Ub59sFJ'), -- João Silva
       (2, 'maria_admin', 'p6AfVsR4wC7y0FbN3rd2e+s4CMelO0xvtsPe5Loffx8tNGdlZZmoMl3aBeBHNt/W'), -- Maria Santos
       (3, 'pedro_operator', 'nH7Ay/gMjZE3WSPw7QEGF8OVkVRsFOBmPb/NKiLDyzg2S3ATgf2rJzSwdHeuB+u0'); -- Pedro Oliveira

-- Insert de exemplo de máquina
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (2, 0, 2, 0, NOW());

-- Inserts para tabela motivos_parada
INSERT INTO motivos_parada (descricao) VALUES ('Não apontada');
INSERT INTO motivos_parada (descricao) VALUES ('Fim de peça');
INSERT INTO motivos_parada (descricao) VALUES ('Quebra de lycra');
INSERT INTO motivos_parada (descricao) VALUES ('Quebra de fio');
INSERT INTO motivos_parada (descricao) VALUES ('Quebra de agulha');
INSERT INTO motivos_parada (descricao) VALUES ('Inspeção de defeito');

-- Inserts para tabela maquina_status
INSERT INTO maquina_status (descricao) VALUES ('Rodando');
INSERT INTO maquina_status (descricao) VALUES ('Parada');
INSERT INTO maquina_status (descricao) VALUES ('Setup');
INSERT INTO maquina_status (descricao) VALUES ('Carga de fio');
INSERT INTO maquina_status (descricao) VALUES ('Sem programação');
INSERT INTO maquina_status (descricao) VALUES ('Sem status');

-- Inserts para a tabela maquina
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_001', 121, 62.94, 4, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_002', 109, 31.71, 2, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_003', 95, 45.12, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_004', 90, 54.63, 2, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_005', 123, 44.04, 6, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_006', 115, 62.75, 3, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_007', 135, 49.69, 6, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_008', 147, 57.09, 2, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_009', 55, 55.91, 4, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_010', 52, 67.72, 7, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_011', 84, 67.64, 3, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_012', 90, 55.76, 7, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_013', 60, 39.82, 9, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_014', 118, 30.45, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_015', 150, 59.93, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_016', 92, 58.84, 9, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_017', 143, 60.24, 1, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_018', 123, 52.82, 8, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_019', 118, 54.55, 10, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_020', 131, 42.62, 3, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_021', 146, 31.69, 8, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_022', 147, 35.83, 5, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_023', 55, 49.56, 10, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_024', 53, 55.74, 6, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_025', 86, 48.44, 1, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_026', 104, 51.82, 8, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_027', 119, 33.67, 4, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_028', 127, 60.95, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_029', 76, 31.19, 7, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_030', 133, 68.91, 10, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_031', 96, 38.68, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_032', 138, 47.79, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_033', 62, 44.55, 2, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_034', 68, 64.03, 9, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_035', 131, 60.05, 9, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_036', 82, 67.6, 9, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_037', 68, 32.04, 4, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_038', 91, 52.61, 3, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_039', 142, 44.88, 2, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_040', 150, 65.9, 8, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_041', 113, 44.78, 1, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_042', 150, 48.18, 6, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_043', 67, 34.57, 8, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_044', 56, 60.61, 4, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_045', 80, 59.95, 3, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_046', 77, 30.13, 6, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_047', 108, 40.13, 8, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_048', 114, 30.74, 6, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_049', 79, 61.72, 2, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_050', 136, 59.97, 3, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_051', 68, 61.06, 9, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_052', 140, 53.55, 2, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_053', 142, 57.81, 7, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_054', 66, 36.66, 7, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_055', 121, 46.4, 2, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_056', 96, 44.43, 7, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_057', 121, 38.82, 7, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_058', 57, 60.5, 2, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_059', 51, 67.13, 10, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_060', 92, 34.92, 9, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_061', 61, 43.1, 10, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_062', 114, 43.77, 5, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_063', 140, 33.67, 5, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_064', 149, 30.68, 6, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_065', 91, 68.01, 1, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_066', 113, 54.94, 2, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_067', 70, 62.18, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_068', 137, 57.6, 9, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_069', 100, 59.73, 10, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_070', 115, 68.28, 1, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_071', 111, 55.97, 2, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_072', 64, 30.57, 3, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_073', 124, 63.23, 3, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_074', 121, 54.61, 8, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_075', 106, 54.48, 6, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_076', 136, 54.72, 7, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_077', 90, 61.16, 4, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_078', 125, 66.69, 5, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_079', 92, 45.2, 5, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_080', 119, 67.35, 8, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_081', 62, 68.17, 6, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_082', 82, 42.92, 7, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_083', 79, 39.75, 9, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_084', 102, 60.11, 3, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_085', 75, 32.52, 9, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_086', 116, 31.97, 7, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_087', 124, 31.57, 5, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_088', 91, 37.47, 7, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_089', 132, 55.48, 7, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_090', 92, 61.6, 2, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_091', 75, 33.51, 1, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_092', 90, 50.13, 4, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_093', 84, 31.44, 5, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_094', 132, 60.3, 5, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_095', 96, 47.47, 9, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_096', 96, 43.47, 2, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_097', 89, 39.08, 2, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_098', 66, 44.63, 9, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_099', 83, 32.29, 9, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_100', 146, 53.09, 3, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_101', 136, 42.36, 5, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_102', 101, 40.02, 10, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_103', 72, 56.9, 2, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_104', 77, 58.72, 4, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_105', 134, 47.18, 3, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_106', 52, 46.85, 5, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_107', 55, 47.2, 5, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_108', 60, 36.0, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_109', 62, 66.32, 4, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_110', 80, 61.73, 4, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_111', 118, 66.42, 7, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_112', 149, 35.06, 4, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_113', 85, 42.29, 8, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_114', 61, 45.02, 8, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_115', 121, 57.99, 6, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_116', 124, 31.24, 9, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_117', 126, 52.83, 1, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_118', 84, 64.54, 9, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_119', 85, 50.43, 2, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_120', 99, 50.16, 1, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_121', 77, 41.52, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_122', 135, 65.5, 6, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_123', 135, 66.85, 1, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_124', 148, 67.26, 3, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_125', 103, 40.2, 8, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_126', 110, 58.56, 8, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_127', 73, 31.22, 10, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_128', 63, 31.49, 9, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_129', 79, 40.92, 4, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_130', 64, 62.58, 7, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_131', 126, 33.69, 1, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_132', 59, 55.12, 7, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_133', 51, 49.31, 2, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_134', 98, 52.61, 3, 'Grupo 4');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_135', 141, 33.38, 10, 'Grupo 1');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_136', 95, 36.42, 9, 'Grupo 2');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_137', 132, 31.94, 10, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_138', 92, 68.54, 8, 'Grupo 5');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_139', 128, 39.67, 10, 'Grupo 3');
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores, grupo) VALUES ('Maquina_140', 125, 64.14, 9, 'Grupo 2');

-- Inserts para a tabela maquina_dados
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (1, 0, 5, NULL, 'Comentário 1', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (2, 0, 2, 5, 'Comentário 2', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (3, 0, 4, NULL, 'Comentário 3', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (4, 0, 3, NULL, 'Comentário 4', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (5, 0, 3, NULL, 'Comentário 5', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (6, 0, 3, NULL, 'Comentário 6', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (7, 0, 2, 3, 'Comentário 7', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (8, 1860, 1, NULL, 'Comentário 8', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (9, 0, 6, NULL, 'Comentário 9', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (10, 0, 2, 3, 'Comentário 10', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (11, 0, 4, NULL, 'Comentário 11', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (12, 0, 2, 4, 'Comentário 12', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (13, 0, 5, NULL, 'Comentário 13', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (14, 0, 6, NULL, 'Comentário 14', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (15, 0, 3, NULL, 'Comentário 15', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (16, 758, 1, NULL, 'Comentário 16', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (17, 0, 5, NULL, 'Comentário 17', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (18, 879, 1, NULL, 'Comentário 18', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (19, 1139, 1, NULL, 'Comentário 19', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (20, 0, 6, NULL, 'Comentário 20', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (21, 0, 6, NULL, 'Comentário 21', NOW());
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
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (32, 0, 6, NULL, 'Comentário 32', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (33, 1733, 1, NULL, 'Comentário 33', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (34, 0, 6, NULL, 'Comentário 34', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (35, 0, 5, NULL, 'Comentário 35', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (36, 0, 5, NULL, 'Comentário 36', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (37, 961, 1, NULL, 'Comentário 37', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (38, 0, 6, NULL, 'Comentário 38', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (39, 0, 3, NULL, 'Comentário 39', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (40, 0, 4, NULL, 'Comentário 40', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (41, 0, 4, NULL, 'Comentário 41', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (42, 0, 5, NULL, 'Comentário 42', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (43, 0, 5, NULL, 'Comentário 43', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (44, 0, 2, 2, 'Comentário 44', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (45, 0, 5, NULL, 'Comentário 45', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (46, 0, 5, NULL, 'Comentário 46', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (47, 0, 2, 6, 'Comentário 47', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (48, 0, 6, NULL, 'Comentário 48', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (49, 0, 3, NULL, 'Comentário 49', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (50, 0, 2, 6, 'Comentário 50', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (51, 1416, 1, NULL, 'Comentário 51', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (52, 0, 2, 5, 'Comentário 52', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (53, 0, 3, NULL, 'Comentário 53', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (54, 0, 5, NULL, 'Comentário 54', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (55, 0, 6, NULL, 'Comentário 55', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (56, 0, 6, NULL, 'Comentário 56', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (57, 0, 5, NULL, 'Comentário 57', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (58, 0, 3, NULL, 'Comentário 58', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (59, 0, 2, 4, 'Comentário 59', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (60, 1820, 1, NULL, 'Comentário 60', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (61, 0, 3, NULL, 'Comentário 61', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (62, 1747, 1, NULL, 'Comentário 62', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (63, 0, 5, NULL, 'Comentário 63', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (64, 1264, 1, NULL, 'Comentário 64', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (65, 0, 6, NULL, 'Comentário 65', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (66, 0, 4, NULL, 'Comentário 66', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (67, 670, 1, NULL, 'Comentário 67', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (68, 0, 5, NULL, 'Comentário 68', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (69, 0, 3, NULL, 'Comentário 69', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (70, 0, 6, NULL, 'Comentário 70', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (71, 832, 1, NULL, 'Comentário 71', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (72, 0, 6, NULL, 'Comentário 72', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (73, 0, 4, NULL, 'Comentário 73', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (74, 0, 4, NULL, 'Comentário 74', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (75, 0, 5, NULL, 'Comentário 75', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (76, 0, 4, NULL, 'Comentário 76', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (77, 0, 6, NULL, 'Comentário 77', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (78, 0, 4, NULL, 'Comentário 78', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (79, 0, 2, 6, 'Comentário 79', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (80, 0, 6, NULL, 'Comentário 80', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (81, 851, 1, NULL, 'Comentário 81', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (82, 0, 4, NULL, 'Comentário 82', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (83, 0, 6, NULL, 'Comentário 83', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (84, 0, 2, 3, 'Comentário 84', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (85, 1285, 1, NULL, 'Comentário 85', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (86, 1175, 1, NULL, 'Comentário 86', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (87, 0, 4, NULL, 'Comentário 87', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (88, 0, 2, 5, 'Comentário 88', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (89, 0, 6, NULL, 'Comentário 89', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (90, 1367, 1, NULL, 'Comentário 90', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (91, 0, 2, 6, 'Comentário 91', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (92, 0, 6, NULL, 'Comentário 92', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (93, 0, 3, NULL, 'Comentário 93', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (94, 0, 2, 2, 'Comentário 94', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (95, 0, 6, NULL, 'Comentário 95', NOW());
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
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (108, 0, 6, NULL, 'Comentário 108', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (109, 0, 3, NULL, 'Comentário 109', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (110, 0, 6, NULL, 'Comentário 110', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (111, 0, 2, 5, 'Comentário 111', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (112, 564, 1, NULL, 'Comentário 112', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (113, 867, 1, NULL, 'Comentário 113', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (114, 0, 6, NULL, 'Comentário 114', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (115, 0, 5, NULL, 'Comentário 115', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (116, 0, 2, 1, 'Comentário 116', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (117, 0, 2, 1, 'Comentário 117', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (118, 1877, 1, NULL, 'Comentário 118', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (119, 0, 4, NULL, 'Comentário 119', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (120, 0, 3, NULL, 'Comentário 120', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (121, 0, 5, NULL, 'Comentário 121', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, comentario, data_hora) VALUES (122, 0, 6, NULL, 'Comentário 122', NOW());
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