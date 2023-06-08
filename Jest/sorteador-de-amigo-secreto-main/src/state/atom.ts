import { atom } from 'recoil';

export const listaParticipantesState = atom<string[]>({
    key: 'listaParticipantesState',
    default: []
})

export const erroState = atom<string>({
    key: 'erroStateMsg',
    default: ''
})

export const resultadoAmigoSecreto = atom<Map<string, string>>({
    key: '',
    default: new Map()
})