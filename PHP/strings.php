<?php

$texto = 'Esta é uma frase com 29 caracteres.';

echo strlen($texto);
echo "\n";

echo substr($texto, 0, 4);
echo "\n";

echo strtoupper($texto);
echo "\n";

echo strtolower($texto);
echo "\n";

echo str_replace('a', 'x', $texto);
echo "\n";

echo strpos($texto, 'a');
echo "\n";

$name = 'Guilherme Henrique';
$x = str_contains($name, 'Guilherme');
echo $x;
echo "\n";
echo str_starts_with($name, 'Guilherme');