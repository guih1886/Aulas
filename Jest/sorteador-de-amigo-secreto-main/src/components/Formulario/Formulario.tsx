import React, { useRef, useState } from 'react'
import { useAdicionarParticipante } from '../../state/hooks/useAdicionarParticipante';
import { useMensagemErro } from '../../state/hooks/useMensagemErro';
import { useRecoilValue } from 'recoil';
import { listaParticipantesState } from '../../state/atom';
import { Card } from '../Card/Card';

export default function Formulario() {

    const [nome, setNome] = useState("");
    const inputRef = useRef<HTMLInputElement>(null)
    const adicionar = useAdicionarParticipante()
    const mensagemErro = useMensagemErro()
    const lista = useRecoilValue(listaParticipantesState)

    const adicionarParticipante = (evento: React.FormEvent<HTMLFormElement>) => {
        evento.preventDefault()
        adicionar(nome)
        setNome("")
        inputRef.current?.focus()
    }

    return (
        <Card>
            <form onSubmit={adicionarParticipante}>
                <input ref={inputRef} value={nome} type="text" onChange={e => setNome(e.target.value)} placeholder='Insira os nomes dos participantes' />
                <button disabled={!nome}>Adicionar</button>
                {mensagemErro && <p role='alert'>{mensagemErro}</p>}
                {lista.map(item => (
                    <div>{item}</div>
                ))}
            </form>
        </Card>
    )
}
