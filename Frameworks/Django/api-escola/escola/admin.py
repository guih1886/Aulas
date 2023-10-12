from django.contrib import admin
from escola.models import Aluno, Curso


class Alunos(admin.ModelAdmin):
    list_display = ('id', 'nome', 'cpf', 'data_nascimento')
    list_display_links = ('id', 'nome')
    search_fields = ('id', 'cpf')
    list_per_page = 20


admin.site.register(Aluno, Alunos)


class Cursos(admin.ModelAdmin):
    list_display = ('id', 'codigo_curso', 'descricao', 'NIVEL')
    list_display_links = ('id', 'descricao')
    search_fields = ('codigo_curso', 'descricao')


admin.site.register(Curso, Cursos)
