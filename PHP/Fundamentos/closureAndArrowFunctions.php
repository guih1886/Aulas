<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php { # closure functions
            # usam variaveis do scopo global, porém sem altera-lás
        
            $a = "Olá, ";
            $b = ". Tudo bem com você?";

            $func = function ($name) use ($a, $b) {
                echo $a . $name . $b;
            };
            $func("Guilherme");
        }
        echo "\n"; {
            # arrow functions, similares com de outras linguagens
            #já usa automaticamente as variaveis globais, e nao precisa de return
            $a = 10;
            $b = 20;

            $arrow = fn($n) => "$n - $a - $b";

            echo $arrow(30);
        }

        ?>
</body>

</html>