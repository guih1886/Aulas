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
    trait Habilidades {
        public $n;
        function saltar($n){
            echo "Eu salto $n metros.";
        }

    }

    class Pessoa {
        use Habilidades; // reutiliza os códigos sem a necessidade de escrita.
    }

    $b = new Pessoa();
    $b->saltar(10);


    ?>
    
</body>
</html>