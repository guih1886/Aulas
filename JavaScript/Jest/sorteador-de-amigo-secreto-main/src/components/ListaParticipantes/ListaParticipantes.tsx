import React from 'react'
import { useListaDeParticipantes } from '../../state/hooks/useListaDeParticipantes'

export default function ListaParticipantes() {
    const lista: string[] = useListaDeParticipantes()
    return (
        <ul>
            {lista.map(participante => <li key={participante}>{participante}</li>)}
        </ul>
    )
}
