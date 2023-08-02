import styles from '../styles/Layout.module.css'
import Navegador from '../components/Navegador'

export default function Estiloso() {
    return (
        <div>
            <Navegador texto="Estiloso" destino='/estiloso'></Navegador>
            <Navegador texto="JSX" destino='/jsx'></Navegador>
            <Navegador texto="Exemplo" destino='/exemplo'></Navegador>
            <Navegador texto="Navagação #1" destino='/cliente/123'></Navegador>
            <Navegador texto="Componente com Estado" destino='/estado'></Navegador>
            <Navegador texto="Integração com API #01" destino='/integracao'></Navegador>
            <Navegador texto="Conteúdo Estático" destino='/estatico'></Navegador>
        </div>
    )
}