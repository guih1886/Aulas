<?php

echo str_repeat('*', 30);

$valor = [10, 100, 1000, 15000];

foreach ($valor as $v) {
    echo "\n";
    echo str_pad($v, 30, '-->', STR_PAD_LEFT);
}