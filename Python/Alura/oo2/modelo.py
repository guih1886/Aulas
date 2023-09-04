class Programa:
    def __init__(self, nome, ano):
        self._nome = nome
        self._ano = ano
        self._likes = 0

    def dar_like(self):
        self._likes += 1

    @property
    def nome(self):
        return self._nome.title()

    @property
    def ano(self):
        return self._ano

    @property
    def likes(self):
        return self._likes

    @ano.setter
    def ano(self, value):
        self._ano = value


class Filme(Programa):
    def __init__(self, nome, ano, duracao):
        super().__init__(nome, ano)
        self._duracao = duracao

    @property
    def duracao(self):
        return self._duracao

    @duracao.setter
    def duracao(self, value):
        self._duracao = value


class Serie(Programa):
    def __init__(self, nome, ano, temporadas):
        super().__init__(nome, ano)
        self._temporadas = temporadas

    @property
    def temporadas(self):
        return self._temporadas

    @temporadas.setter
    def temporadas(self, value):
        self._temporadas = value


filme = Filme("john wick", 2022, 180)
filme.dar_like()
filme.dar_like()
print(f"Filme: {filme.nome} - Ano: {filme.ano} - Duração: {filme.duracao}m - Likes: {filme.likes}")

serie = Serie("breaking bad", 2006, 6)
serie.dar_like()
serie.dar_like()
serie.dar_like()
print(f"Série: {serie.nome} - Ano: {serie.ano} - Temporadas: {serie.temporadas} - Likes: {serie.likes}")
