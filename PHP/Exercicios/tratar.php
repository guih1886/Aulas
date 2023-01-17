<?php

if ($_SERVER['request_method'] != 'post') {
    die('Acesso negado.');
    exit();
}
;
if (!isset($_POST['usuario']) || !isset($_POST['senha'])) {
    echo 'Usuario ou senha inválidos.';
}
;

if (!isset($_POST['check_condicoes']) || $_POST['check_condicoes'] != 'aceito') {
    header('Location: index.html');
    exit();
}

echo '<p>ok</p>';