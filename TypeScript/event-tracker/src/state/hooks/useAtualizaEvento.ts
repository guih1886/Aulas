import { useSetRecoilState } from "recoil"
import { IEvento } from "../../interfaces/IEvento"
import { listaDeEventosState } from "../atom"

const useAtualizaEvento = () => {
    const setListaDeEventos = useSetRecoilState<IEvento[]>(listaDeEventosState)
    return (evento: IEvento) => {
        return setListaDeEventos(listaAntiga => {
            const indice = listaAntiga.findIndex(evt => evt.id === evento.id)
            return [...listaAntiga.slice(0, indice), evento, ...listaAntiga.slice(indice + 1)]
        });
    }
}


export default useAtualizaEvento;