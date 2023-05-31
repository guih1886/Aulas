import { Box, Button, TextField, Typography, FormControl, InputLabel, Select, MenuItem } from '@mui/material'
import React, { useEffect, useState } from 'react'
import http from '../../../http';
import ITag from '../../../interfaces/ITag';
import IRestaurante from '../../../interfaces/IRestaurante';

export default function FormularioPrato() {
    const [nomePrato, setNomePrato] = useState("");
    const [descricaoPrato, setDescricaoPrato] = useState("");
    const [tag, setTag] = useState("");
    const [restaurante, setRestaurante] = useState('');
    const [imagem, setImagem] = useState<File | null>();
    const [tags, setTags] = useState<ITag[]>([]);
    const [restaurantes, setRestaurantes] = useState<IRestaurante[]>([]);

    useEffect(() => {
        http.get<{ tags: ITag[] }>("tags/").then(resp => setTags(resp.data.tags))
        http.get<IRestaurante[]>("restaurantes/").then(resp => setRestaurantes(resp.data))
    }, [])


    const aoSubmeterForm = (evento: React.FormEvent<HTMLFormElement>) => {
        evento.preventDefault();
        const formData = new FormData();
        formData.append("nome", nomePrato)
        formData.append("tag", tag)
        formData.append("descricao", descricaoPrato)
        formData.append("restaurante", restaurante)
        if (imagem) {
            formData.append("imagem", imagem)
        }
        http.request({  
            url: 'pratos/',
            method: 'POST',
            headers: {
                'Content-Type': 'multipart/form-data'
            },
            data: formData
        }).then(() => alert("Prato cadastrado com sucesso.")).catch(e => console.log(e))
    }

    function selecionarArquivo(evento: React.ChangeEvent<HTMLInputElement>) {
        if (evento.target.files?.length) {
            setImagem(evento.target.files[0])
        } else {
            setImagem(null)
        }
    }
    return (
        <>
            <Box sx={{ display: 'flex', flexDirection: 'column', alignItems: 'center', flexGrow: 1 }}>
                <Typography variant='h6' component="h1" >Formulário de Pratos</Typography>
                <Box component="form" sx={{ width: '100%' }} onSubmit={aoSubmeterForm}>
                    <TextField
                        value={nomePrato}
                        onChange={e => setNomePrato(e.target.value)}
                        label="Nome do Prato"
                        variant="standard"
                        fullWidth
                        required
                        margin='dense' />
                    <TextField
                        value={descricaoPrato}
                        onChange={e => setDescricaoPrato(e.target.value)}
                        label="Descrição do Prato"
                        variant="standard"
                        fullWidth
                        required
                        margin='dense' />
                    <FormControl margin='dense' fullWidth >
                        <InputLabel id="select-tag">Tag</InputLabel>
                        <Select id='select-tag' value={tag} onChange={e => setTag(e.target.value)}>
                            {tags.map(tag =>
                                <MenuItem value={tag.value} key={tag.id}>{tag.value}</MenuItem>
                            )}
                        </Select>
                    </FormControl>
                    <FormControl margin='dense' fullWidth >
                        <InputLabel id="select-restaurante">Restaurante</InputLabel>
                        <Select id='select-restaurante' value={restaurante} onChange={e => setRestaurante(e.target.value)}>
                            {restaurantes.map(restaurante =>
                                <MenuItem value={restaurante.id} key={restaurante.id}>{restaurante.nome}</MenuItem>
                            )}
                        </Select>
                    </FormControl>
                    <input type="file" onChange={selecionarArquivo} />
                    <Button sx={{ marginTop: 1 }} type='submit' variant='outlined' fullWidth>Salvar</Button>
                </Box>
            </Box>
        </>
    )
}
