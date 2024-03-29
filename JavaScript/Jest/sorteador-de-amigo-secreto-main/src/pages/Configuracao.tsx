import React from 'react'
import Formulario from '../components/Formulario/Formulario'
import ListaParticipantes from '../components/ListaParticipantes/ListaParticipantes'
import { Card } from '../components/Card/Card'
import Rodape from '../components/Rodape/Rodape'

export default function Configuracao() {
    return (
        <Card>
            <section>
                <h2>Vamos começar!</h2>
                <Formulario />
                <ListaParticipantes />
                <Rodape />
            </section>
        </Card>
    )
}
