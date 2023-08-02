<?php

include("conexao.php");

//obter os dados
$obterDados = file_get_contents("php://input");

//extrair os dados
$extrairDados = json_decode($obterDados);

//separar os dados
$idCurso = $extrairDados->cursos->idCurso;


//sql
$sql = "DELETE cursos WHERE idCurso = $idCurso";
mysqli_query($conexao, $sql);