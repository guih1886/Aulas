import React from 'react'
import ReactDom from 'react-dom'
import Filho from './componentes/Filho'
//import { BomDia, BoaNoite } from './componentes/Multiplos'
//import Multi from './componentes/Multiplos'
//import Saudacao from './componentes/Saudacao'
import Pai from './componentes/Pai'

ReactDom.render(
    <div>
       {/*<Saudacao tipo='Boa noite' nome='Cleber'/>*/}
        <Pai nome='Paulo' sobrenome='Silva'>
            <Filho nome='Pedro' />
            <Filho nome='Paulo' />
            <Filho nome='Carla' />
        </Pai>

    </div>
    , document.getElementById('root'))