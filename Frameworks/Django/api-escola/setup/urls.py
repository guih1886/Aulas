from django.contrib import admin
from django.urls import path, include
from escola.views import AlunosViewSet, CursosViewSet
from rest_framework import routers

route = routers.DefaultRouter()  # incluindo rotas padrão
route.register('alunos', AlunosViewSet, basename='Alunos')
route.register('cursos', CursosViewSet, basename='Cursos')


urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include(route.urls)),
]
