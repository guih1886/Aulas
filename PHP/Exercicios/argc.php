<?php

$vezes = 10;
$min = 0;
$max = 100;

function gerarArq($vezes, $min, $max)
{
    $file = fopen(time() . '.txt', 'w');
    for ($i = 0; $i < $vezes; $i++) {
        fwrite($file, rand($min, $max) . PHP_EOL);
    }
    fclose($file);
}

if ($argc == 4) {
    $vezes = $argv[1];
    $min = $argv[2];
    $max = $argv[3];
    gerarArq($vezes, $min, $max);
} elseif ($argc == 2) {
    $vezes = $argv[1];
    gerarArq($vezes, 0, 100);
} else {
    echo "Paramêtros inválidos.";
}