import React from 'react'
import ReactDom from 'react-dom'
//import { BomDia, BoaNoite } from './componentes/Multiplos'
//clsimport Multi from './componentes/Multiplos'
import Saudacao from './componentes/Saudacao'

ReactDom.render(
    <div>
        <Saudacao tipo='Boa noite' nome='Cleber'/>
    </div>
    , document.getElementById('root'))