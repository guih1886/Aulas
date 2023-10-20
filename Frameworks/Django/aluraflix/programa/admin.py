from django.contrib import admin
from programa.models import Programa

class ListarProgramas(admin.ModelAdmin):
    list_display = ('id', 'titulo', 'tipo', 'data_lancamento', 'likes')
    list_display_links = ('id', 'titulo')
    list_filter = ['tipo']
    ordering = ['likes']
    search_fields = ['titulo']
    list_per_page = 10

admin.site.register(Programa, ListarProgramas)