import React, { Component } from 'react'
import style from './Formulario.module.scss'
import Botao from '../Botao'
import { v4 as uuidv4 } from 'uuid'
import { ITarefa } from '../../types/tarefa';

export default class Formulario extends Component<{ setTarefas: React.Dispatch<React.SetStateAction<ITarefa[]>> }> {
    state = {
        tarefa: "",
        tempo: "00:00:00"
    }

    adicionarTarefa(evento: React.FormEvent) {
        evento.preventDefault();
        this.props.setTarefas(tarefasAntigas => [
            ...tarefasAntigas, {
                ...this.state,
                selecionado: false,
                completado: false,
                id: uuidv4()
            }
        ]);
        this.setState({
            tarefa: "",
            tempo: "00:00:00"
        })
    }
    render() {
        return (
            <form className={style.novaTarefa} onSubmit={this.adicionarTarefa.bind(this)}>
                <div className={style.inputContainer}>
                    <label htmlFor="tarefa">
                        Adicione um novo estudo
                    </label>
                    <input
                        type="text"
                        name="tarefa"
                        value={this.state.tarefa}
                        onChange={e => this.setState({ ...this.state, tarefa: e.target.value })}
                        id="tarefa"
                        placeholder="O que você quer estudar"
                        required
                    />
                </div>
                <div className={style.inputContainer}>
                    <label htmlFor="tempo">
                        Tempo
                    </label>
                    <input
                        type="time"
                        step="1"
                        name="tempo"
                        value={this.state.tempo}
                        onChange={e => this.setState({ ...this.state, tempo: e.target.value })}
                        id="tempo"
                        min="00:00:00"
                        max="01:30:00"
                        required
                    />
                </div>
                <Botao type="submit" texto='Adicionar' />
            </form>
        )
    }
}
