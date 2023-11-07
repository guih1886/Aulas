from django.contrib import admin
from front.models import Categoria, Pesquisas


class ListarCategoria(admin.ModelAdmin):
    list_display = ("id", "nome", "ativo")
    list_display_links = ("nome",)
    ordering = ["id", "nome"]
    search_fields = ["nome"]
    list_editable = ("ativo",)
    list_per_page = 20

admin.site.register(Categoria, ListarCategoria)

class ListarPesquisas(admin.ModelAdmin):
    list_display = ("id", "categoria_id", "pergunta", "resposta")
    list_display_links = ("pergunta",)
    ordering = ["categoria_id", "pergunta"]
    search_fields = ["pergunta"]
    list_per_page = 20

admin.site.register(Pesquisas, ListarPesquisas)