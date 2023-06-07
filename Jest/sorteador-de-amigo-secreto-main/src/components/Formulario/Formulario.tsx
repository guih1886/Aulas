import React, { useRef, useState } from 'react'
import { useAdicionarParticipante } from '../../state/hooks/useAdicionarParticipante';
import { useMensagemErro } from '../../state/hooks/useMensagemErro';

export default function Formulario() {

    const [nome, setNome] = useState("");
    const inputRef = useRef<HTMLInputElement>(null)
    const adicioparParticipante = useAdicionarParticipante()
    const mensagemErro = useMensagemErro()

    const adicionarParticipante = (evento: React.FormEvent<HTMLFormElement>) => {
        evento.preventDefault()
        adicioparParticipante(nome)
        setNome("")
        inputRef.current?.focus()
    }

    return (
        <form onSubmit={adicionarParticipante}>
            <input ref={inputRef} type="text" onChange={e => setNome(e.target.value)} placeholder='Insira os nomes dos participantes' />
            <button disabled={!nome}>Adicionar</button>
            {mensagemErro && <p role="alert">{mensagemErro}</p>}
        </form>
    )
}
