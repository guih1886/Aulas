import { ITarefa } from '../../types/tarefa'
import ItemLista from './Item/ItemLista'
import style from './Lista.module.scss'

interface Props {
    tarefa: ITarefa[],
    selecionaTarefas: (tarefaSelecionada: ITarefa) => void
}

export default function Lista({ tarefa, selecionaTarefas }: Props) {
    return (
        <aside className={style.listaTarefas}>
            <h2> Estudos do dia </h2>
            <ul>
                {tarefa.map((item) => (
                    <ItemLista key={item.id} selecionaTarefa={selecionaTarefas} {...item} />
                ))}
            </ul>
        </aside>
    )
}
