<?php
include("conexao.php");

//sql
$sql = "SELECT * FROM cursos";
//executar
$executar = mysqli_query($conexao, $url);
//vetor
$cursos = [];
//indice
$indice = 0;

while ($linha = mysqli_fetch_assoc($executar)) {
    $cursos[$indice]['idCurso'] = $linha['idCurso'];
    $cursos[$indice]['nomeCurso'] = $linha['nomeCurso'];
    $cursos[$indice]['precoCurso'] = $linha['precoCurso'];
    $indice++;
}


json_encode(['cursos' => $cursos]);

var_dump($cursos);