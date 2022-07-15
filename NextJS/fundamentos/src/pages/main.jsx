import React from "react";
import Cabecalho from "../components/Cabecalho";
import Link from 'next/link'


export default function Main() {
    return (
        /*<React.Fragment>
        <Cabecalho titulo="Aprendendo Next & React"/>
        <Cabecalho titulo="E estou amando!!!"/>
        </React.Fragment>*/
        <Link href={"/"}>Voltar</Link>
    )
}