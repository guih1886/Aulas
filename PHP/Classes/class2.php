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
    class Humano
    {
        function __construct(private $name, private $idade, private $sexo) # no php 8 pode-se definir as propriedades direto nos parametros construtor
    
        {
            $this->name = $name;
            $this->idade = date('Y') - $idade;
            $this->sexo = $sexo;
        }

        public function falar()
        {
            $sex = '';
            if ($this->sexo === "M") {
                $sex = "homem";
            } else {
                $sex = 'mulher';
            }
            ;
            return (
                "Olá $this->name, fiquei sabendo que é $sex e que tem $this->idade anos."
            );

        }
    }

    $obj = new Humano("Guilherme", 1994, "M"); # passa os valores para o construtor, que passa para o resto da classe.
    
    echo $obj->falar();
    ?>
</body>

</html>