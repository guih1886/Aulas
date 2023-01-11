<?php
//%s = string | %d = int | %f = float
//%('caracter','quantidade de vezes')s caracteres de formatacao
//

$valor = 100;
$preco = 1115.35;

echo sprintf("A sala tem capacidade de %s pessoas.\n", $valor);
echo sprintf("A sala tem capacidade de %05s pessoas.\n", $valor);

//
echo sprintf("O valor do produto é de: R$ %0.2f\n", $preco);
