<?php
$cidades = ["Campinas", "São Paulo"];

$numeros = [0, 1, 2, 3];

$clientes = [
    "nome" => "João Carlos",
    "idade" => 20,
    "vivo" => true,
];

$numerosCompostos = [
    [1, 2, 3, 4, 5],
    [10, 20, 30, 40, 50],
    [100, 200, 300, 400, 500]
];

echo $cidades[0]; #Campinas
echo "\n";
echo $numeros[3]; #3
echo "\n";
echo $clientes["nome"]; #João Carlos
echo "\n";
echo $numerosCompostos[0][2]; #3
echo "\n";
echo $numerosCompostos[2][4]; #500