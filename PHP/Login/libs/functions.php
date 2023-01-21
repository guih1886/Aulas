<?php


function verify_session()
{
    return isset($_SESSION['usuario']);
}