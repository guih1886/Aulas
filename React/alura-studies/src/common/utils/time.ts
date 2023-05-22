export function tempoEmSegundos(tempo: string) {
    const [hora = '0', minutos = '0', segundos = '0'] = tempo.split(':');

    const horaEmSegundos = Number(hora) * 3600
    const minutosEmSegundos = Number(minutos) * 60
    return horaEmSegundos + minutosEmSegundos + Number(segundos);
}