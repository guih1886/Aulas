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

  Esquema do Cenário: Propondo um lance invalido
    Dado um lançe de <valor> reais
    Quando propõe ao leilao
    Então o lançe não é aceito
    Exemplos:
      | valor |
      | 0     |
      | -1    |

  Cenário: Propondo vários lances válidos para o mesmo usuario
    Dado dois lançes
      | valor | nomeUsuario |
      | 0     | fulano      |
      | -1    | fulano      |
    Quando propõe vários lançes ao leilao
    Então o segundo lance não é aceito