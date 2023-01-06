<?php

// include caso nao exista o arquivo, executa com erros. O require, não executa e trava o fluxo

include 'class.php';

$obj = new Humano("Guilherme", 28, "M");
$obj->falar();


require('./arrays.php');

echo $cidades;