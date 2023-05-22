import React from 'react'
import style from './Botao.module.scss';

export default class Botao extends React.Component<{
    texto: string,
    type?: "button" | "submit" | "reset" | undefined,
    onClick?: () => void
}> {
    render() {
        const { texto, type = "button", onClick } = this.props
        return (
            <button onClick={onClick} className={style.botao} type={type}>{texto}</button>
            
        )
    }
}
