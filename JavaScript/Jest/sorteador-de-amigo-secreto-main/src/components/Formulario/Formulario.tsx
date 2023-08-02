import React, { useRef, useState } from 'react'
import { useAdicionarParticipante } from '../../state/hooks/useAdicionarParticipante';
import { useMensagemErro } from '../../state/hooks/useMensagemErro';
import './estilo.css'

export default function Formulario() {

    const [nome, setNome] = useState("");
    const inputRef = useRef<HTMLInputElement>(null)
    const adicionar = useAdicionarParticipante()
    const mensagemErro = useMensagemErro()

    const adicionarParticipante = (evento: React.FormEvent<HTMLFormElement>) => {
        evento.preventDefault()
        adicionar(nome)
        setNome("")
        inputRef.current?.focus()
    }

    return (
        <form className='form-grupo' onSubmit={adicionarParticipante}>
            <div className="grupo-input-btn">
                <input ref={inputRef} value={nome} type="text" onChange={e => setNome(e.target.value)} placeholder='Insira os nomes dos participantes' />
                <button disabled={!nome}>Adicionar</button>
            </div>
            {mensagemErro && <p className='alerta erro' role='alert'>{mensagemErro}</p>}
        </form>
    )
}
