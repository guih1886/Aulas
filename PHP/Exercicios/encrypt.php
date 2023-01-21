<?php

$password = 'abcd1234';

password_hash($password, PASSWORD_DEFAULT);

$result = password_verify($password, '$2y$10$aftwzRYB9X4/mUbmhIjHZOOxJ7DAw4A9fYmLh6/U72dVLKdpQwm32');

if ($result) {
    echo 'iguais';
} else {
    echo 'diferentes';
}