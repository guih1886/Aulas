<?php

$value = isset($argv[1]) ? $argv[1] : 10;

for ($i = 0; $i < $value; $i++) {
    echo $i;
}

echo "\n";
echo "\n";

foreach ($argv as $k => $v) {
    echo $k . ' = ' . $v . "\n";
}

//executando em linha de comando php argv.php 100 ele retorna 100 ou caso contrario retorna 10
// php argv.php 100 200 300 400 500