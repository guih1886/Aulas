<?php

//explode transforma um conjunto de dados em um array, e o implode faz o contrário

$array = ["José, Maria, Claudio, Joaquim"];
$string = 'Joao, Glauco, Fernando, Renata';

$a = explode(',', $string); //separador e string
foreach($a as $i){
    echo $i . "\n";
}

$b = implode($array);
echo $b;