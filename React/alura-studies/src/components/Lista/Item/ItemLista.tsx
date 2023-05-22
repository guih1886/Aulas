import React from 'react';
import { ITarefa } from '../../../types/tarefa';
import style from './Item.module.scss'

interface Props extends ITarefa {
    selecionaTarefa: (tarefaSelecionada: ITarefa) => void
}

export default function ItemLista({ tarefa, tempo, selecionado, completado, id, selecionaTarefa }: Props) {
    return (
        <li className={` ${selecionado ? style.itemSelecionado : style.item}`} onClick={() => selecionaTarefa({
            tarefa,
            tempo,
            selecionado,
            completado,
            id
        })}>
            <h3>
                {tarefa}
            </h3>
            <span>
                {tempo}
            </span>
        </li>
    )
}
