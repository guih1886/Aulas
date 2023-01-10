<?php
$a = '  isso é uma string       ';

//remove os espaços do começo e do final
echo trim($a);
echo "\n";

//rtrim remove do lado direito, e ltrim remove do lado esquerdo
echo ltrim($a);
echo "\n";
echo rtrim($a);

//o segundo parametro remove de toda a variavel, do comeco e do fibal
$a = 'abcdea';
echo "\n";
echo trim($a, 'a');