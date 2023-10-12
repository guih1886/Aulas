from django.http import JsonResponse


def alunos(request):
    if request.method == 'GET':
        alunos = {'id': 1, 'nome': 'Guilherme'}
        return JsonResponse(alunos)
