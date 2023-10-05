from django.shortcuts import render, get_object_or_404
from galeria.models import Fotografia


def index(request):
    fotos = Fotografia.objects.order_by("data_fotografia").filter(ativo=True)
    return render(request, 'galeria/index.html', {"cards": fotos})


def imagem(request, foto_id):
    fotografia = get_object_or_404(Fotografia, pk=foto_id)
    return render(request, 'galeria/imagem.html', {"fotografia": fotografia})


def buscar(request):
    fotos = Fotografia.objects.order_by("data_fotografia").filter(ativo=True)

    if "busca" in request.GET:
        palavra_a_buscar = request.GET["busca"]
        if palavra_a_buscar:
            fotos = fotos.filter(nome__icontains=palavra_a_buscar)
    return render(request, 'galeria/buscar.html', {"cards": fotos})
