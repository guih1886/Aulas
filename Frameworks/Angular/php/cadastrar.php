<?php

include("conexao.php");

//obter os dados
$obterDados = file_get_contents("php://input");

//extrair os dados
$extrairDados = json_decode($obterDados);

//separar os dados
$nomeCurso = $extrairDados->cursos->nomeCurso;
$valorCurso = $extrairDados->cursos->valorCurso;

//sql
$sql = "INSERT INTO cursos (nomeCurso, precoCurso) VALUES ('$nomeCurso', '$valorCurso')";
mysqli_query($conexao, $sql);

//exportar os dados cadastrados
$curso = [
    'nomeCurso' => $nomeCurso,
    'valorCurso' => $valorCurso
];

json_encode(['curso' => $curso]);