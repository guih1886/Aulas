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
    class Veiculo
    {
        public $marca;
        public $ano;
        public $tipoLocomocao = "Rodoviário";
    }

    class Automovel extends Veiculo
    {

        function __construct(public $potencia, public $numPortas)
        {
            $this->potencia = $potencia;
            $this->numPortas = $numPortas;
        }

        function info()
        {
            return "O automóvel é da {$this->marca}, tem {$this->potencia}cv do ano {$this->ano} com {$this->numPortas} portas e é do tipo {$this->tipoLocomocao} ";
        }
    }
    ;
    $obj = new Automovel(300, 4);
    $obj->marca = 'Volks';
    $obj->ano = 1994;
    echo $obj->info();
    ?>
</body>

</html>