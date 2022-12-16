# Uso de objetos namedtuple
import collections


def main():
    # TODO: Crie uma namedtuple para armazenar coordenadas
    cordenadas = collections.namedtuple("Cordenada", 'x y')

    p1 = cordenadas(10, 20)
    p2 = cordenadas(10, 20)
    print(p1, p2)
    print(p1.x, p2.y)

    # TODO: Use _replace() para criar uma instância nova
    p1 = p1._replace(x=100)
    print(p1)


if __name__ == "__main__":
    main()
