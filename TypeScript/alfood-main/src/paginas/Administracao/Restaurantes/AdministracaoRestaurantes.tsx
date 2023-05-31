import { Button, Container, Paper, Table, TableBody, TableCell, TableContainer, TableHead, TableRow } from '@mui/material'
import { useState, useEffect } from 'react'
import IRestaurante from '../../../interfaces/IRestaurante'
import http from '../../../http';
import { Link as RouterLink } from 'react-router-dom'

export default function AdministracaoRestaurantes() {
    const [restaurantes, setRestaurantes] = useState<IRestaurante[]>([]);

    useEffect(() => {
        http.get("restaurantes/").then(resp => { setRestaurantes(resp.data) })
    }, [])

    function excluir(restauranteAExcluir: IRestaurante): void {
        http.delete(`restaurantes/${restauranteAExcluir.id}/`).then(() => {
            const listaRestaurante = restaurantes.filter(restaurante => restaurante.id !== restauranteAExcluir.id)
            setRestaurantes([...listaRestaurante])
        })
    }

    return (
        <>
            <Container maxWidth="lg" sx={{ marginTop: 1 }}>
                <Paper sx={{ padding: 2 }}>
                    <TableContainer>
                        <Table>
                            <TableHead>
                                <TableRow>
                                    <TableCell>Nome</TableCell>
                                    <TableCell>Editar</TableCell>
                                    <TableCell>Excluir</TableCell>
                                </TableRow>
                            </TableHead>
                            <TableBody>
                                {restaurantes.map(restaurante =>
                                (
                                    <TableRow key={restaurante.id}>
                                        <TableCell>{restaurante.nome}</TableCell>
                                        <TableCell>[ <RouterLink to={`/admin/restaurantes/${restaurante.id}`}>Editar</RouterLink>]</TableCell>
                                        <TableCell><Button variant='outlined' color='error' onClick={() => excluir(restaurante)}>Excluir</Button></TableCell>
                                    </TableRow>
                                ))}
                            </TableBody>
                        </Table>
                    </TableContainer>
                </Paper>
            </Container>
        </>
    )
}