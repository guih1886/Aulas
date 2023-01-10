<?php

//strstr retorna o restante da string após uma ocorrencia (sensitive)
$nome = 'Guilherme Henrique';
echo strstr($nome, "H");

//case insensitive 
$nome = 'Guilherme Henrique';
echo stristr($nome, 'lher');

//com o needle de terceiro parametro, a funcao retorna o que está para tras dela, excluindo a needle