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
    $name = 'guilherme henrique';
    $apelido = 'guih1886';
    $nameMaiusculo = strtoupper($name);
    $apelidoMaiusculo = strtoupper($apelido);
    ?>
    <p><?="Meu nome é " . $nameMaiusculo . 'e meu apelido é ' . $apelidoMaiusculo ?></p>
</body>

</html>