import Layout from '../components/Layout'
import estiloso from '../styles/Estiloso.module.css'

export default function Estiloso() {
    return (
        <Layout titulo="CSS em módulos">
            <div className={estiloso.roxo}>
                <h1>Estilo usando CSS módulos</h1>
            </div>
        </Layout>
    )
}