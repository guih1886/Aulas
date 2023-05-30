import { Button, TextField } from '@mui/material'
import React, { useState } from 'react'
import axios from 'axios'

export default function FormularioRestaurante() {
    const [nomeRestaurante, setNomeRestaurante] = useState("");

    const aoSubmeterForm = (evento: React.FormEvent<HTMLFormElement>) => {
        evento.preventDefault();
        axios.post("http://localhost:8000/api/v2/restaurantes/", { nome: nomeRestaurante }).then(resp => { alert("Cadastrado com sucesso") })
    }
    return (
        <form onSubmit={aoSubmeterForm}>
            <TextField value={nomeRestaurante}
                onChange={e => setNomeRestaurante(e.target.value)}
                label="Nome do Restaurante"
                variant="standard" />
            <Button type='submit' variant='outlined'>Salvar</Button>
        </form>
    )
}
