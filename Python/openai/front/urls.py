from django.urls import path
from front.views import busca

urlpatterns = [
    path('', busca, name="buscar"),
]
