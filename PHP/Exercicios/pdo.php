<?php

require_once('EasyPDO.php');
use EasyPDO\EasyPDO;

$gestor = new EasyPDO();

$clientes = $gestor->select("SELECT * FROM clientes");
print_r($clientes);