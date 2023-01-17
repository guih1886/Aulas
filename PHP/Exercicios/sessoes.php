<?php

//salva informacoes em arquivo no server side
session_start();

$_SESSION['name'] = 'Guilherme';
$_SESSION['age'] = 28;
$_SESSION['fruits'] = ['Apple', 'Orange', 'Strawberry'];
unset($_SESSION['fruits']); // desfaz uma chave/valor

print_r($_SESSION);


session_destroy(); //exclui toda a sessao