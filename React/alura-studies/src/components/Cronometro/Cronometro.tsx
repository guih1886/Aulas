import { useEffect, useState } from 'react'
import Botao from '../Botao'
import Relogio from './Relogio/Relogio'
import style from './Cronometro.module.scss'
import { ITarefa } from '../../types/tarefa'
import { tempoEmSegundos } from '../../common/utils/time'

interface Props {
    selecionado: ITarefa | undefined
}

export default function Cronometro({ selecionado }: Props) {
    const [tempo, setTempo] = useState<number>()

    useEffect(() => {
        if (selecionado?.tempo) {
            setTempo(tempoEmSegundos(selecionado.tempo));
        }
    }, [selecionado]);

    return (
        <div className={style.cronometro}>
            <p className={style.titulo}>Escolha um card e inicie o cronômetro</p>
            <div className={style.relogioWrapper}>
                <Relogio tempo={tempo} />
            </div>
            <Botao texto='Começar!' ></Botao>
        </div>
    )
}
