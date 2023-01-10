<?php
$apresentar = true;

?>

<?php
if ($apresentar) {
    echo 'Este paragrafo é apresentado';
} else {
    echo 'nao existe nada para apresentar';
}

?>

<!-- melhor para conseguir modificar ou adicionar propriedades -->
<?php if ($apresentar): ?>
    <div>
        <p>Apresenta esse paragrafo</p>
    </div>
<?php else: ?>
    <p>Nao existe nada para apresentar</p>
<?php endif; ?>