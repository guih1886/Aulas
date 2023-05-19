import React from 'react'
import ItemLista from './Item/ItemLista'

export default function Lista() {
    const tarefas = [{
        tarefa: 'React',
        tempo: '01:00:00'
    }, {
        tarefa: 'JavaScript',
        tempo: '02:00:00'
    },
    {
        tarefa: 'TypeScript',
        tempo: '03:00:00'
    }]
    return (
        <aside>
            <h2> Estudos do dia </h2>
            <ul>
                {tarefas.map((item, index) => (
                    <ItemLista key={index} {...item}/>
                ))}
            </ul>
        </aside>
    )
}
