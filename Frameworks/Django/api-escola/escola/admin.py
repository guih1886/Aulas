from django.contrib import admin
from escola.models import Aluno, Curso, Matricula


class Alunos(admin.ModelAdmin):
    list_display = ('id', 'nome', 'cpf', 'data_nascimento')
    list_display_links = ('id', 'nome')
    search_fields = ('id', 'cpf')
    list_per_page = 20


admin.site.register(Aluno, Alunos)


class Cursos(admin.ModelAdmin):
    list_display = ('id', 'codigo_curso', 'descricao', 'nivel')
    list_display_links = ('id', 'codigo_curso')
    search_fields = ('codigo_curso', 'descricao')


admin.site.register(Curso, Cursos)


class Metriculas(admin.ModelAdmin):
    list_display = ('id', 'aluno', 'curso', 'periodo')
    list_display_links = ('id','aluno')


admin.site.register(Matricula, Metriculas)
