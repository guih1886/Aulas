export default function Cabecalho(props) {
    //props é somente leitura
    return (
        <header>
            <div>
                <h1>{props.titulo}</h1>
            </div>
        </header>
    )
}