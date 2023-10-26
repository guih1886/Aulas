import sqlite3

print("Conectando...")
conn = sqlite3.connect('db.sqlite3')
cursor = conn.cursor()

# criando tabelas
TABLES = {}
cursor.execute('''
    CREATE TABLE IF NOT EXISTS 'jogos' (
        id INTEGER PRIMARY KEY,
        nome TEXT NOT NULL,
        categoria TEXT NOT NULL,
        console TEXT NOT NULL
    )
''')

cursor.execute('''
      CREATE TABLE IF NOT EXISTS `usuarios` (
      `nome` varchar(20) NOT NULL,
      `nickname` varchar(8) NOT NULL,
      `senha` varchar(100) NOT NULL,
      PRIMARY KEY (`nickname`)
      )''')

# Inserindo usuários
usuario_sql = 'INSERT INTO usuarios (nome, nickname, senha) VALUES (?, ?, ?)'
usuarios = [
    ("Bruno Divino", "BD", "alohomora"),
    ("Camila Ferreira", "Mila", "paozinho"),
    ("Guilherme Louro", "Cake", "python_eh_vida")
]

cursor.executemany(usuario_sql, usuarios)

cursor.execute('select * from usuarios')
print(' -------------  Usuários:  -------------')
for user in cursor.fetchall():
    print(user)

# inserindo jogos
jogos_sql = 'INSERT INTO jogos (nome, categoria, console) VALUES (?, ?, ?)'
jogos = [
    ('Tetris', 'Puzzle', 'Atari'),
    ('God of War', 'Hack n Slash', 'PS2'),
    ('Mortal Kombat', 'Luta', 'PS2'),
    ('Valorant', 'FPS', 'PC'),
    ('Crash Bandicoot', 'Hack n Slash', 'PS2'),
    ('Need for Speed', 'Corrida', 'PS2'),
]
cursor.executemany(jogos_sql, jogos)

cursor.execute('select * from jogos')
print(' -------------  Jogos:  -------------')
for jogo in cursor.fetchall():
    print(jogo[1])

# commitando se não nada tem efeito
conn.commit()

cursor.close()
conn.close()
