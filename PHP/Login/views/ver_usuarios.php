<div class="container">
    <div class="row">
        <div class="col-sm-6 offset-sm-3">
            <div class="row">
                <div class="col">
                    <h3>Usuarios</h3>
                </div>
                <div class="col text-end">
                    <a href="logout.php">Logout</a>
                </div>
            </div>
            <hr>
            <?php if (count($usuarios) == 0): ?>
                <p>Não foram encontrados usuários.</p>
            <?php else: ?>
                <table class="table">
                    <thead>
                        <tr>
                            <th>Usuario:</th>
                            <th>Nome completo:</th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php foreach ($usuarios as $usuario): ?>
                            <tr>
                                <td>
                                    <?= $usuario['usuario']; ?>
                                </td>
                                <td>
                                    <?= $usuario['nome_completo']; ?>
                                </td>
                            </tr>
                        <?php endforeach; ?>
                    </tbody>
                </table>
            <?php endif; ?>
        </div>
    </div>
</div>