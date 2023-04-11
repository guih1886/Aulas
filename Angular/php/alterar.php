<?php

include("conexao.php");

//obter os dados
$obterDados = file_get_contents("php://input");

//extrair os dados
$extrairDados = json_decode($obterDados);

//separar os dados
$idCurso = $extrairDados->cursos->idCurso;
$nomeCurso = $extrairDados->cursos->nomeCurso;
$valorCurso = $extrairDados->cursos->valorCurso;

//sql
$sql = "UPDATE cursos SET nomeCurso='$nomeCurso', precoCurso=$valorCurso WHERE idCurso=$idCurso";
mysqli_query($conexao, $sql);

//exportar os dados cadastrados
$curso = [
    'idCurso' => $idCurso,
    'nomeCurso' => $nomeCurso,
    'valorCurso' => $valorCurso
];

json_encode(['curso' => $curso]);