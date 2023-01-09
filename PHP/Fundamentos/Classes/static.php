<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    class Operacoes
    {
        static function numeroAleatorio($min, $max)
        {
            return rand($min, $max);
        }

        static function calcularFormula($a, $b)
        {
            return ($a * 2) + ($b * $a);
        }
    }

    echo Operacoes::numeroAleatorio(10, 100);
    /* $b1 = new Operacoes();
    echo "\n";
    echo $b1->numeroAleatorio(50, 100); */

    ?>
</body>

</html>