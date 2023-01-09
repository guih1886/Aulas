<?php

declare(strict_types=1);

//retorna um array, string, int etc
function returnArray(): array
{
    return [];
}
;

//strict typing

function falar(?string $mensagem) // '?' operador nullable, permite passar o valor null para a função

{
    echo $mensagem;
}

function somar(int|float $n1, int $n2)
{
    return $n1 + $n2;
}


falar("olá mundo\n");
falar(null);
echo somar(100.5, 100);
//falar(10); // sem o strict type é possivel, declarando ele, não



//null coalescing operator, age como um ternário, verificando se a variavel é null
echo "\n";

$nome = null;
$name = $nome ?? 'Sem nome';
echo $name;