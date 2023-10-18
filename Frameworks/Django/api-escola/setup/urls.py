from django.contrib import admin
from django.urls import path, include
from escola.views import AlunosViewSet, CursosViewSet, MatriculaViewSet, ListaMatriculasAluno, ListaAlunosMatriculados
from rest_framework import routers
from django.conf import settings
from django.conf.urls.static import static

route = routers.DefaultRouter()  # incluindo rotas padrão
route.register('alunos', AlunosViewSet, basename='Alunos')
route.register('cursos', CursosViewSet, basename='Cursos')
route.register('matriculas', MatriculaViewSet, basename='Matriculas')


urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include(route.urls)),
    path('alunos/<int:pk>/matriculas', ListaMatriculasAluno.as_view()),
    path('cursos/<int:pk>/matriculas', ListaAlunosMatriculados.as_view()),
] + static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)
