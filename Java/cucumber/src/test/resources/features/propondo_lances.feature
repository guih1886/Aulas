# language: pt

Funcionalidade: Propondo lances ao leilão

  Cenário: Propondo um lançe valido
    Dado um lançe valido
    Quando propõe ao leilao
    Então o lance é aceito


  Cenário: Propondo vários lances válidos
    Dado um lançe de 10 reais do usuario "fulano"
    E um lançe de 15 reais do usuario "beltrano"
    Quando propõe vários lançes ao leilao
    Então os lançes são aceitos