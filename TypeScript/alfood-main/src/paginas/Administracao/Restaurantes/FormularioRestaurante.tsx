import { Box, Button, TextField, Typography } from '@mui/material'
import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router-dom';
import IRestaurante from '../../../interfaces/IRestaurante';
import http from '../../../http';

export default function FormularioRestaurante() {
    const parametros = useParams();
    const [nomeRestaurante, setNomeRestaurante] = useState("");

    useEffect(() => {
        http.get<IRestaurante>(`restaurantes/${parametros.id}/`).then(resp => setNomeRestaurante(resp.data.nome))
    }, [parametros])

    const aoSubmeterForm = (evento: React.FormEvent<HTMLFormElement>) => {
        evento.preventDefault();
        if (parametros.id) {
            http.put(`restaurantes/${parametros.id}/`, { nome: nomeRestaurante }).then(resp => { alert("Atualizado com sucesso") })
        } else {
            http.post("restaurantes/", { nome: nomeRestaurante }).then(resp => { alert("Cadastrado com sucesso") })
        }
    }
    return (
        <>
            <Box sx={{ display: 'flex', flexDirection: 'column', alignItems: 'center', flexGrow: 1 }}>
                <Typography variant='h6' component="h1" >Formulário de restaurantes</Typography>
                <Box component="form" sx={{ width: '100%' }} onSubmit={aoSubmeterForm}>
                    <TextField
                        value={nomeRestaurante}
                        onChange={e => setNomeRestaurante(e.target.value)}
                        label="Nome do Restaurante"
                        variant="standard"
                        fullWidth
                        required />
                    <Button sx={{ marginTop: 1 }} type='submit' variant='outlined' fullWidth>Salvar</Button>
                </Box>
            </Box>
        </>
    )
}
