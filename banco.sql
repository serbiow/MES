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

SELECT m.id, m.apelido, md.rpm, md.status 
FROM maquina m
JOIN maquina_dados md ON m.id = md.maquina_id
WHERE md.data_hora = (
    SELECT MAX(md2.data_hora) 
    FROM maquina_dados md2 
    WHERE md2.maquina_id = m.id
)
ORDER BY m.apelido;

/*INSERTS*/

INSERT INTO usuario (nome, cargo, horario, cpf)
VALUES ('João Silva', 'master', 'manha', '12345678901'),
       ('Maria Santos', 'admin', 'tarde', '23456789012'),
       ('Pedro Oliveira', 'operator', 'noite', '34567890123');
       
INSERT INTO login (usuario_id, login_nome, senha) 
VALUES (1, 'joao_master', 'senha123'), -- João Silva
       (2, 'maria_admin', 'senha456'), -- Maria Santos
       (3, 'pedro_operator', 'senha789'); -- Pedro Oliveira

-- Inserts para a tabela 'maquina'
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_001', 76, 30.53, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_002', 100, 31.11, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_003', 88, 44.25, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_004', 111, 37.43, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_005', 90, 45.41, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_006', 117, 45.06, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_007', 129, 61.98, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_008', 126, 50.02, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_009', 106, 49.27, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_010', 84, 49.9, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_011', 127, 62.0, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_012', 111, 40.78, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_013', 142, 63.21, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_014', 63, 69.22, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_015', 75, 52.07, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_016', 64, 43.48, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_017', 67, 54.4, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_018', 75, 38.55, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_019', 113, 62.09, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_020', 114, 45.21, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_021', 116, 46.92, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_022', 85, 66.3, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_023', 65, 60.31, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_024', 97, 40.85, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_025', 68, 53.12, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_026', 126, 57.31, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_027', 99, 37.98, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_028', 101, 66.2, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_029', 77, 60.97, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_030', 145, 32.73, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_031', 63, 58.35, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_032', 128, 50.16, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_033', 80, 32.23, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_034', 55, 59.59, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_035', 118, 58.94, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_036', 74, 54.7, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_037', 98, 58.87, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_038', 56, 56.51, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_039', 120, 31.44, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_040', 82, 33.49, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_041', 54, 38.44, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_042', 143, 51.78, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_043', 125, 47.33, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_044', 51, 43.83, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_045', 54, 65.7, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_046', 112, 39.39, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_047', 112, 49.31, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_048', 86, 30.63, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_049', 137, 52.93, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_050', 96, 33.43, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_051', 121, 58.5, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_052', 91, 35.17, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_053', 61, 63.25, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_054', 62, 61.74, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_055', 92, 60.16, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_056', 126, 43.21, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_057', 78, 43.79, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_058', 125, 52.74, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_059', 100, 52.91, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_060', 56, 53.19, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_061', 71, 60.49, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_062', 109, 54.96, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_063', 141, 38.8, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_064', 65, 38.31, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_065', 110, 39.26, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_066', 93, 56.36, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_067', 127, 42.04, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_068', 145, 47.88, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_069', 90, 47.56, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_070', 133, 63.26, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_071', 54, 65.25, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_072', 147, 65.9, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_073', 99, 60.55, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_074', 129, 46.13, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_075', 149, 47.58, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_076', 132, 65.82, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_077', 147, 68.67, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_078', 119, 55.62, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_079', 111, 49.27, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_080', 54, 59.8, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_081', 71, 61.37, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_082', 52, 67.99, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_083', 112, 56.84, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_084', 137, 30.52, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_085', 131, 64.62, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_086', 109, 38.03, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_087', 130, 31.13, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_088', 60, 55.22, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_089', 64, 37.29, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_090', 123, 40.76, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_091', 139, 67.01, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_092', 88, 56.35, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_093', 69, 47.96, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_094', 64, 56.68, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_095', 104, 60.46, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_096', 133, 66.1, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_097', 65, 58.14, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_098', 76, 64.92, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_099', 121, 30.18, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_100', 57, 57.66, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_101', 115, 69.53, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_102', 100, 35.64, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_103', 121, 57.49, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_104', 101, 33.86, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_105', 80, 46.51, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_106', 54, 32.86, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_107', 115, 59.15, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_108', 69, 30.95, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_109', 108, 35.34, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_110', 101, 34.0, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_111', 56, 64.11, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_112', 70, 62.97, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_113', 107, 39.39, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_114', 51, 51.02, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_115', 81, 43.76, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_116', 126, 63.15, 2);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_117', 106, 58.8, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_118', 134, 50.29, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_119', 87, 64.02, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_120', 56, 50.54, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_121', 120, 33.26, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_122', 92, 67.82, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_123', 129, 58.63, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_124', 107, 57.1, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_125', 142, 51.22, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_126', 93, 57.02, 1);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_127', 111, 50.5, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_128', 122, 66.72, 9);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_129', 139, 59.29, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_130', 62, 36.87, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_131', 91, 46.98, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_132', 104, 47.72, 4);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_133', 133, 64.74, 8);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_134', 115, 49.61, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_135', 95, 30.82, 10);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_136', 116, 36.52, 7);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_137', 86, 34.01, 6);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_138', 57, 48.03, 3);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_139', 144, 48.62, 5);
INSERT INTO maquina (apelido, finura, diametro, numero_alimentadores) VALUES ('Maquina_140', 121, 39.94, 6);

-- Inserts para a tabela 'maquina_dados'
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (1, 900, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (2, 1953, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (3, 0, 'desligado', 'Motivo_7', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (4, 0, 'desligado', 'Motivo_4', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (5, 721, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (6, 0, 'desligado', 'Motivo_6', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (7, 1773, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (8, 873, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (9, 1604, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (10, 873, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (11, 999, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (12, 903, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (13, 0, 'desligado', 'Motivo_13', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (14, 1185, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (15, 1544, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (16, 1215, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (17, 784, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (18, 0, 'desligado', 'Motivo_18', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (19, 1904, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (20, 0, 'desligado', 'Motivo_20', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (21, 684, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (22, 1179, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (23, 0, 'desligado', 'Motivo_23', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (24, 1209, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (25, 0, 'desligado', 'Motivo_25', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (26, 938, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (27, 0, 'desligado', 'Motivo_27', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (28, 1182, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (29, 0, 'desligado', 'Motivo_29', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (30, 1097, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (31, 1778, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (32, 709, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (33, 1270, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (34, 1652, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (35, 0, 'desligado', 'Motivo_35', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (36, 1856, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (37, 1184, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (38, 584, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (39, 1563, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (40, 710, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (41, 1945, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (42, 1946, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (43, 0, 'desligado', 'Motivo_43', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (44, 1603, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (45, 0, 'desligado', 'Motivo_45', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (46, 961, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (47, 0, 'desligado', 'Motivo_47', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (48, 898, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (49, 1825, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (50, 890, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (51, 508, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (52, 1115, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (53, 0, 'desligado', 'Motivo_53', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (54, 0, 'desligado', 'Motivo_54', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (55, 1175, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (56, 658, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (57, 1311, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (58, 1411, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (59, 1791, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (60, 1466, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (61, 699, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (62, 1471, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (63, 0, 'desligado', 'Motivo_63', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (64, 586, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (65, 0, 'desligado', 'Motivo_65', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (66, 1511, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (67, 1150, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (68, 1368, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (69, 1502, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (70, 0, 'desligado', 'Motivo_70', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (71, 0, 'desligado', 'Motivo_71', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (72, 1384, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (73, 1676, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (74, 0, 'desligado', 'Motivo_74', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (75, 666, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (76, 0, 'desligado', 'Motivo_76', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (77, 814, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (78, 672, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (79, 1520, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (80, 1899, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (81, 942, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (82, 0, 'desligado', 'Motivo_82', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (83, 0, 'desligado', 'Motivo_83', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (84, 1387, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (85, 557, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (86, 1008, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (87, 0, 'desligado', 'Motivo_87', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (88, 0, 'desligado', 'Motivo_88', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (89, 1037, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (90, 1256, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (91, 0, 'desligado', 'Motivo_91', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (92, 964, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (93, 1030, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (94, 0, 'desligado', 'Motivo_94', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (95, 0, 'desligado', 'Motivo_95', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (96, 1399, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (97, 682, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (98, 0, 'desligado', 'Motivo_98', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (99, 648, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (100, 1541, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (101, 1675, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (102, 0, 'desligado', 'Motivo_102', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (103, 998, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (104, 777, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (105, 1679, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (106, 0, 'desligado', 'Motivo_106', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (107, 1211, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (108, 930, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (109, 1111, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (110, 1262, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (111, 1642, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (112, 1452, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (113, 1702, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (114, 1026, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (115, 1158, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (116, 782, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (117, 504, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (118, 1413, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (119, 598, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (120, 0, 'desligado', 'Motivo_120', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (121, 0, 'desligado', 'Motivo_121', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (122, 522, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (123, 1418, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (124, 1555, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (125, 0, 'desligado', 'Motivo_125', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (126, 1005, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (127, 927, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (128, 1712, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (129, 1034, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (130, 0, 'desligado', 'Motivo_130', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (131, 1281, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (132, 1876, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (133, 1775, 'ligado', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (134, 0, 'desligado', 'Motivo_134', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (135, 1342, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (136, 994, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (137, 0, 'desligado', 'Motivo_137', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (138, 1421, 'alarme', NULL, NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (139, 0, 'desligado', 'Motivo_139', NOW());
INSERT INTO maquina_dados (maquina_id, rpm, status, motivo_desligamento, data_hora) VALUES (140, 1222, 'ligado', NULL, NOW());