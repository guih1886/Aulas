<?php
session_start();

define('CONTROLO') or die('Acesso negado.');

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="assets/bootstrap.min.css">
    <title>Clube</title>
</head>

<body>
    <?php
    require_once('./libs/config.php');
    require_once('./libs/functions.php');
    require_once('./libs/EasyPDO.php');

    //routes system
    require_once('rotas.php');

    ?>
    <script src="assets/bootstrap.bundle.min.js"></script>
</body>

</html>