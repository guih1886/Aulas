<?php
$name = 'Guilherme Henrique';
$email = 'guilherme_18henrique@yahoo.com.br';

$texto = <<<LABEL
    Olá $name,
    Seu e-mail ($email) foi validado com sucesso.
LABEL;

echo $texto;
