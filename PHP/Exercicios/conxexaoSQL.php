<?php

$gestor = new PDO("mysql:host=localhost;dbname=loja", 'root', '');
$dados = $gestor->query("select * from clientes");
$clientes = $dados->fetchAll(PDO::FETCH_ASSOC);