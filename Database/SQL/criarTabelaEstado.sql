-- CRIANDO A TABELA DE ESTADOS
CREATE TABLE ESTADOS2 (
    ID INT UNSIGNED NOT NULL AUTO_INCREMENT,
    NOME VARCHAR(45) NOT NULL,
    SIGLA VARCHAR(2) NOT NULL,
    REGIAO ENUM(
        "NORTE",
        "SUL",
        "SUDESTE",
        "NORDESTE",
        "CENTRO-OESTE"
    ) NOT NULL,
    POPULACAO DECIMAL(5, 2) NOT NULL,
    PRIMARY KEY (ID),
    UNIQUE KEY(NOME),
    UNIQUE KEY(SIGLA)
);