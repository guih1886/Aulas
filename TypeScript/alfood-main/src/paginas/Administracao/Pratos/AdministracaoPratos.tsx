import { Button, Container, Paper, Table, TableBody, TableCell, TableContainer, TableHead, TableRow } from '@mui/material'
import { useState, useEffect } from 'react'
import http from '../../../http';
import { Link as RouterLink } from 'react-router-dom'
import IPrato from '../../../interfaces/IPrato';

export default function AdministracaoPratos() {
    const [pratos, setPratos] = useState<IPrato[]>([]);

    useEffect(() => {
        http.get("pratos/").then(resp => { setPratos(resp.data) })
    }, [])

    function excluir(pratoAExcluir: IPrato): void {
        http.delete(`pratos/${pratoAExcluir.id}/`).then(() => {
            const listaPratos = pratos.filter(prato => prato.id !== pratoAExcluir.id)
            setPratos([...listaPratos])
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
                                    <TableCell>Tag</TableCell>
                                    <TableCell>Imagem</TableCell>
                                    <TableCell>Editar</TableCell>
                                    <TableCell>Excluir</TableCell>
                                </TableRow>
                            </TableHead>
                            <TableBody>
                                {pratos.map(prato =>
                                (
                                    <TableRow key={prato.id}>
                                        <TableCell>{prato.nome}</TableCell>
                                        <TableCell>{prato.tag}</TableCell>
                                        <TableCell>
                                            <a href={prato.imagem} target='_blank' rel='noreferrer'>Ver imagem</a>
                                        </TableCell>
                                        <TableCell>[ <RouterLink to={`/admin/pratos/${prato.id}`}>Editar</RouterLink>]</TableCell>
                                        <TableCell><Button variant='outlined' color='error' onClick={() => excluir(prato)}>Excluir</Button></TableCell>
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