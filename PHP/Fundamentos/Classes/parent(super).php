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
    class Retangulo
    {
        public $l;
        public $a;
        function __construct($l, $a)
        {
            $this->l = $l;
            $this->a = $a;
        }
        function calcArea()
        {
            return $this->l * $this->a;
        }
    }

    class Quadrado extends Retangulo
    {
        function __construct($l)
        {
            parent::__construct($l, $l);
        }
    }

    $b = new Quadrado(10);
    echo $b->calcArea();
    ?>

</body>

</html>