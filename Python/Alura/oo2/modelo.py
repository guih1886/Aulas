class Programa:
    def __init__(self, nome, ano):
        self._nome = nome
        self._ano = ano
        self._likes = 0

    # como um toString
    def __str__(self):
        return f"Filme: {self._nome} - Ano: {self._ano} - Likes: {self._likes}"

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

    def __str__(self):
        return f"Filme: {self.nome} - Ano: {self.ano} - Duração: {self.duracao}m - Likes: {self.likes}"

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

    def __str__(self):
        return f"Série: {self.nome} - Ano: {self.ano} - {self.temporadas} temporadas - Likes: {self.likes}"

    @property
    def temporadas(self):
        return self._temporadas

    @temporadas.setter
    def temporadas(self, value):
        self._temporadas = value


filme = Filme("john wick", 2022, 180)
filme.dar_like()
filme.dar_like()

serie = Serie("breaking bad", 2006, 6)
serie.dar_like()
serie.dar_like()
serie.dar_like()

lista_files_e_series = [filme, serie]

for programa in lista_files_e_series:
    print(programa)
