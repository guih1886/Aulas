url = "https://cursos.alura.com.br/search?moedaDestino=dolar&moedaOrigem=real"

# Sanitização da URL
url = url.strip()

# Validação da URL
if url == "":
    raise ValueError("A URL está vazia.")

# Separa a URL base
index_interrogacao = url.find("?")
url_base = url[:index_interrogacao]
print(url_base)

# Busca os valores das querys
query = "moedaDestino"
url_parametros = url[index_interrogacao + 1:]
indice_valor = url_parametros.find(query) + len(query) + 1
indice_e_comercial = url_parametros.find("&", indice_valor)

if indice_e_comercial == -1:
    valor = url_parametros[indice_valor:]
else:
    valor = url_parametros[indice_valor:indice_e_comercial]

print(valor)
