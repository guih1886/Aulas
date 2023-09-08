import re

url = ""

padrao_url = re.compile("(http(s)?://)?(www.)?bytebank.com(.br)?/cambio")
padrao_url.match(url)