<?php

if (isset($_COOKIE['meu-cookie'])) {
    echo $_COOKIE['meu-cookie'];
} else {
    setcookie('meu-cookie', date('H:i:s'), );
}


// para remover é somente colocar a expiração para o passado -1
if (!isset($_COOKIE['visitou-o-site'])) {
    setcookie('visitou-o-site', true, time() + 360);
    echo 'É a primeira visita ao site!';
} else {
    echo "<p>você já esteve aqui</p>";
}