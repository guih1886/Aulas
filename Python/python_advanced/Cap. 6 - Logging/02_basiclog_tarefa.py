# Uso do módulo logging
import logging

# TODO: Use o módulo embutido logging


def main():
    # TODO: Use basicConfig para configurar seu logging
    logging.basicConfig(level=logging.DEBUG, filename='output.log')

    # Testando cada um dos níveis de log
    logging.debug("Esta é uma mensagem de debug")
    logging.info("Esta é uma mensagem de informação")
    logging.warning("Esta é uma mensagem de aviso")
    logging.error("Esta é uma mensagem de erro")
    logging.critical("Esta é uma mensagem crítica")

    # TODO: Use strings para formatar o log


if __name__ == "__main__":
    main()
