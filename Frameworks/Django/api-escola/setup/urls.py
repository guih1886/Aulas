from django.contrib import admin
from django.urls import path, include
from escola.views import AlunosViewSet, CursosViewSet, MatriculaViewSet
from rest_framework import routers

route = routers.DefaultRouter()  # incluindo rotas padrão
route.register('alunos', AlunosViewSet, basename='Alunos')
route.register('cursos', CursosViewSet, basename='Cursos')
route.register('matriculas', MatriculaViewSet, basename='Matriculas')


urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include(route.urls)),
]
