SECRET_KEY = 'alura'

SQLALCHEMY_DATABASE_URI = 'mysql+mysqlconnector://{username}:{password}@{host}:{port}/{database_name}'.format(
    username='root',
    password='',
    host='localhost',
    port='3306',
    database_name='jogoteca'
)
