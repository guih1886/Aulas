import React, { useState, useReducer } from 'react'

export default function App() {
    const [number, setNumber] = useReducer((number, newNumber) => number + newNumber, 0)
    //1 argumento é uma funcao, e o segundo o estado inicial
    
    const [checked, toggle] = useReducer((checked) => !checked, false)
    return (
        <>
            <h1 onClick={() => setNumber(1)}>{number}</h1>
            <input type={'checkbox'} onChange={toggle} value={checked} />{checked ? 'Checked' : 'Not checked'}
        </>
        //dessa forma, a cada click ele executa a função
    )
}
