<?php

defined('CONTROLO') or die('Acesso negado');

$rota = null;

if (!verify_session() && $_SESSION['REQUEST_METHOD'] != 'POST') {
    $rota = 'LOGIN';
} elseif (!verify_session() && $_SESSION['REQUEST_METHOD'] == 'POST') {
    $rota = 'LOGIN_SUBMIT';
}

//layout shows
switch ($rota) {
    case 'LOGIN':
        //show login form
        require_once('./views/login_form.php');
        break;
    case 'LOGIN_SUBMIT':
        //tried login
        $bd = new EasyPDO();
        $params = [
            'usuario' => $_POST['text_usuario'],
        ];
        $result = $bd->select('SELECT id_usuario, usuario FROM usuarios WHERE usuario = :usuario');

        if (count($result) == 0) {
            $erro = "Usuario ou senha inválidos.";
            require_once('../views/login_form.php');
            return;
        } else {
            $usuario = $result[0];
        }

        if (password_verify($_POST['text_password'], $usuario['senha'])) {
            $_SESSION['usuario'] = $usuario['usuario'];
            header('Location: index.php');
            return;
        } else {
            $erro = "Usuario ou senha inválidos.";
            require_once('../views/login_form.php');
            return;
        }
        break;
    case 'LOGADO':
        $bd = new EasyPDO();

        $usuarios = $bd->select("SELECT AES_DECRYPT(nome_completo, UNHEX(SHA2('" . AES_KEY . "',512)))) AS Nome Completo FROM usuarios");

        require_once('../views/ver_usuarios.php');

}