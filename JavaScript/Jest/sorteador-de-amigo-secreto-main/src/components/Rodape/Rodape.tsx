import React from 'react'
import { useNavigate } from 'react-router-dom'
import './estilo.css'
import { useListaDeParticipantes } from '../../state/hooks/useListaDeParticipantes'
import { useSorteador } from '../../state/hooks/useSorteador'

export default function Rodape() {
    const navigate = useNavigate()
    const participantes = useListaDeParticipantes()
    const sortear = useSorteador()
    const iniciar = () => {
        sortear()
        navigate("/sorteio")
    }
    return (
        <footer className='rodape-configuracoes'>
            <button className='botao' disabled={participantes.length < 3} onClick={iniciar}>Iniciar brincadeira!</button>
        </footer>
    )
}
