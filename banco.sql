/*DATABASE*/

create database iAxxMES;
use iAxxMES;

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

CREATE TABLE maquina_dados (
    id INT AUTO_INCREMENT PRIMARY KEY,
    maquina_id INT NOT NULL,
    rpm INT(4) NOT NULL,
    status ENUM('rodando', 'parada', 'setup', 'carga de fio', 'sem programação') NOT NULL,
    motivo_parada VARCHAR(255),
    data_hora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP(),
    FOREIGN KEY (maquina_id) REFERENCES maquina(id)
);

SELECT m.id, m.apelido, md.rpm, md.status, md.motivo_parada
FROM maquina m
JOIN maquina_dados md ON m.id = md.maquina_id
WHERE md.data_hora = (
    SELECT MAX(md2.data_hora) 
    FROM maquina_dados md2 
    WHERE md2.maquina_id = m.id
)
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
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (1, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (2, 0, 'parada', 'Motivo parada 15', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (3, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (4, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (5, 0, 'parada', 'Motivo parada 20', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (6, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (7, 1985, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (8, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (9, 1151, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (10, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (11, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (12, 0, 'parada', 'Motivo parada 28', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (13, 1656, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (14, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (15, 0, 'parada', 'Motivo parada 25', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (16, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (17, 0, 'parada', 'Motivo parada 45', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (18, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (19, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (20, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (21, 0, 'parada', 'Motivo parada 87', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (22, 603, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (23, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (24, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (25, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (26, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (27, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (28, 1810, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (29, 0, 'parada', 'Motivo parada 29', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (30, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (31, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (32, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (33, 0, 'parada', 'Motivo parada 70', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (34, 829, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (35, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (36, 949, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (37, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (38, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (39, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (40, 1926, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (41, 0, 'parada', 'Motivo parada 15', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (42, 1791, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (43, 908, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (44, 952, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (45, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (46, 0, 'parada', 'Motivo parada 58', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (47, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (48, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (49, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (50, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (51, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (52, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (53, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (54, 800, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (55, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (56, 1846, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (57, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (58, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (59, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (60, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (61, 1129, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (62, 1410, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (63, 1090, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (64, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (65, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (66, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (67, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (68, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (69, 783, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (70, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (71, 1450, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (72, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (73, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (74, 0, 'parada', 'Motivo parada 27', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (75, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (76, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (77, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (78, 0, 'parada', 'Motivo parada 4', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (79, 0, 'parada', 'Motivo parada 11', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (80, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (81, 689, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (82, 1809, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (83, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (84, 0, 'parada', 'Motivo parada 58', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (85, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (86, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (87, 0, 'parada', 'Motivo parada 79', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (88, 0, 'parada', 'Motivo parada 28', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (89, 0, 'parada', 'Motivo parada 27', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (90, 0, 'parada', 'Motivo parada 53', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (91, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (92, 1630, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (93, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (94, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (95, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (96, 0, 'parada', 'Motivo parada 22', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (97, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (98, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (99, 0, 'parada', 'Motivo parada 96', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (100, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (101, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (102, 856, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (103, 608, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (104, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (105, 0, 'parada', 'Motivo parada 84', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (106, 1962, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (107, 758, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (108, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (109, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (110, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (111, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (112, 0, 'parada', 'Motivo parada 58', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (113, 0, 'parada', 'Motivo parada 63', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (114, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (115, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (116, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (117, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (118, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (119, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (120, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (121, 1119, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (122, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (123, 715, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (124, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (125, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (126, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (127, 716, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (128, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (129, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (130, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (131, 0, 'setup', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (132, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (133, 0, 'parada', 'Motivo parada 58', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (134, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (135, 1393, 'rodando', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (136, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (137, 0, 'carga de fio', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (138, 0, 'parada', 'Motivo parada 6', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (139, 0, 'sem programação', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_parada, data_hora) VALUES (140, 0, 'parada', 'Motivo parada 94', NOW());