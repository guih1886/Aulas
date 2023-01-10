<?php
$dados = [
    ['joao', 'm', 'portugal'],
    ['ana', 'f', 'Brasil']
];

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <table border="5">
        <thead>
            <tr>
                <th>Nome</th>
                <th>Gênero</th>
                <th>País</th>
            </tr>
        </thead>
        <tbody>
            <?php foreach ($dados as $item): ?>
                <tr>
                    <td><?= $item[0]?></td>
                    <td><?= $item[1]?></td>
                    <td><?= $item[2]?></td>
                </tr>
            <?php endforeach; ?>
        </tbody>
    </table>

</body>

</html>