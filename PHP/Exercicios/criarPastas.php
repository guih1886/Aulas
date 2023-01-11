<?php

mkdir(dirname(__FILE__).'/pasta1/teste', 0777,true);
/* 
mkdir('teste', 0777, true); */

rmdir('teste'); // somente exclui de estiver vazias