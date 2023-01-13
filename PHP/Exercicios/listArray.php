<?php

//list cria um anova variavel a partir de um array,  o array original nao é odificado
$nomes = ['Joao', 'Pedro', 'Miguel'];

list($nome1, $nome2, $nome3) = $nomes;

echo $nome1 . PHP_EOL;
echo $nome2 . PHP_EOL;
echo $nome3 . PHP_EOL;


//extract cria variaveis a partir de um array multidimencional. Nao altera o original
$empresa = [
    'adm' => ['Joao', 'Pedro', 'Miguel'],
    'rh' => ['Carlos', 'Bete'],
    'vendas' => ['Antonio'],
];

extract($empresa);
print_r($adm);
print_r($rh);
print_r($vendas);