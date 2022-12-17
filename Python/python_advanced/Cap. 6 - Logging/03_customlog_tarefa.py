# Personalizando o retorno do logging
import logging

dados = {'Pessoa': 'Guilherme'}

# TODO: Crie uma outra função para rodar o log


def outra_funcao():
    logging.info("Esta é outra mensagem de informação", extra=dados)


def main():
    # TODO: Defina o nível de log para debug e um arquivo para salvar
    # o retorno. Use também uma formatação personalizada
    formato = '%(asctime)s: %(levelname)s | %(Pessoa)s (%(funcName)s): %(message)s'
    logging.basicConfig(
        level=logging.DEBUG,
        filename='customOutput.log',
        format=formato
    )

    logging.info("Esta é uma mensagem de informação", extra=dados)
    logging.warning("Esta é uma mensagem de aviso", extra=dados)
    outra_funcao()


if __name__ == "__main__":
    main()
