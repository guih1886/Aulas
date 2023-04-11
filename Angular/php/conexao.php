<?php
$url = "localhost";
$user = "root";
$senha = "";
$base = "api";


//conexação
$conexao = mysqli_connect($url, $user, $senha, $base);

//arrumar caracteres
mysqli_set_charset($conexao, "utf8");

?>