#
# Exemplo de como usar os comando Break e Continue
#

def loopBreak():
    for x in range(5, 10):
        if x == 7:
            break
        print(x)

# loopBreak()


def loopContinue():
    for x in range(5, 10):
        if x == 7:
            continue
        print(x)


loopContinue()
