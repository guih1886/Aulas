<?php
class Humano
{
    private $name;
    private $idade;
    private $sexo;

    function __construct($name, $idade, $sexo)
    {
        $this->name = $name;
        $this->idade = $idade;
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

$obj = new Humano("Guilherme", 28, "M"); # passa os valores para o construtor, que passa para o resto da classe.

echo $obj->falar();

?>