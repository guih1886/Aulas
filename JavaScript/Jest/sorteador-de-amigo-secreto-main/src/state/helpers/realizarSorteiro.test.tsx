import { realizarSorteio } from "./realizarSorteio";

describe("dado um sorteio de amigo secreto", () => {
    test('cadda participante não sorteie seu próprio nome', () => {
        const participantes = ['Randall', 'Mabelle', 'Russell', "Cecelia"]
        const sorteio = realizarSorteio(participantes)
        participantes.forEach(participante => {
            const amigoSecreto = sorteio.get(participante)
            expect(amigoSecreto).not.toEqual(participante)
        });
    })
})