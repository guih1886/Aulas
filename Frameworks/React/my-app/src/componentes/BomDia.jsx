import React from "react"

export default props =>
    //r.fragment inclui sem necessáriamente criar uma tag
    /*<div>
        ...... 
    </div>*/
    /*<React.Fragment>
        <h1>Bom dia {props.nome}!</h1>
        <h2>Até logo!</h2>
    </React.Fragment>*/
    [
        <h1 key='h1'>Bom dia {props.nome}!</h1>,
        <h2 key='h2'>Até logoo!</h2>
    ]
