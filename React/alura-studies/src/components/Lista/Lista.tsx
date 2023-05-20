import { ITarefa } from '../../types/tarefa'
import ItemLista from './Item/ItemLista'
import style from './Lista.module.scss'

export default function Lista({ tarefa }: { tarefa: ITarefa[] }) {
    return (
        <aside className={style.listaTarefas}>
            <h2> Estudos do dia </h2>
            <ul>
                {tarefa.map((item, index) => (
                    <ItemLista key={index} {...item} />
                ))}
            </ul>
        </aside>
    )
}
