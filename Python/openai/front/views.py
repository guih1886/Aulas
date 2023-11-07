from django.shortcuts import render
from django.http import request
from front.models import Categoria, Pesquisas
import openai
import os
import dotenv


dotenv.load_dotenv()
openai.api_key = os.getenv("API_KEY")


def busca(request):
    categorias = Categoria.objects.filter(ativo=True)
    if request.method == 'POST':
        user_input = request.POST.get('user_input')
        categoria_id = request.POST.get('categorias')
        categoria_selecionada = categorias[int(categoria_id) - 1]
        prompt_sistema = f"""
        Voçê tira dúvidas sobre tecnologia.
        Você deve se basear na categoria abaixo:
        ##### Categoria válida
        {categoria_selecionada}
        #### Pergunta
        {user_input}
        Responda à {user_input} com base na {categoria_selecionada}
        ### Exemplo
        Categoria: Senhas, Pergunta: Como faço, Resposta: Para fazer uma senha forte digite 9 digitos, letras maiusculas e 
        minusculas e coloque caracteres especiais. Retorne somente a resposta do exemplo.
        Se a pergunta não tiver relacionado com a categoria, resposta "A pergunta não se refere a categoria."
        Limite a resposta em até 256 caracteres.
        """

        resposta = openai.chat.completions.create(
            model="gpt-3.5-turbo",
            messages=[
                {
                    "role": "system",
                    "content": prompt_sistema
                },
                {
                    "role": "user",
                    "content": str(user_input)
                }
            ],
            temperature=1,
            max_tokens=280,
            top_p=1,
            frequency_penalty=0,
            presence_penalty=0
        )
        resposta_msg = resposta.choices[0].message.content
        if "A pergunta não se refere" not in resposta_msg:
            pesquisa = Pesquisas(
                categoria=categoria_selecionada, pergunta=user_input, resposta=resposta_msg)
            pesquisa.save()
        modo = 'post'
    else:
        user_input = ''
        categoria_id = ''
        categoria_selecionada = ''
        resposta_msg = ''
        modo = 'get'

    return render(request, 'index.html', {'categorias': categorias, 'resposta': resposta_msg, 'modo': modo})
