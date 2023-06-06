import { useSetRecoilState } from "recoil"
import { IEvento } from "../../interfaces/IEvento"
import { listaDeEventosState } from "../atom"
import { obterId } from "../../util/util";

const useAdicionarEvento = () => {
    const setListaEventos = useSetRecoilState<IEvento[]>(listaDeEventosState);

    return (evento: IEvento) => {
        const hoje = new Date();
        if (evento.inicio < hoje) {
            throw new Error("Eventos não podem ser com data inferior a atual.")
        }
        evento.id = obterId();
        return setListaEventos(listaAntiga => [...listaAntiga, evento])
    }
}

export default useAdicionarEvento;