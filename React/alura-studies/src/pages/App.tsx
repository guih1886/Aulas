import { useState } from 'react';
import Cronometro from '../components/Cronometro/Cronometro';
import Formulario from '../components/Formulario';
import Lista from '../components/Lista/Lista';
import style from './App.module.scss';
import { ITarefa } from '../types/tarefa';

function App() {
  const [tarefas, setTarefas] = useState<ITarefa[]>([]);
  const [selecionado, setSelecionado] = useState<ITarefa>();

  function selecionaTarefa(tarefaSelecionada: ITarefa) {
    setSelecionado(tarefaSelecionada);
    setTarefas(tarefasAnteriores => tarefasAnteriores.map(tarefa => ({
      ...tarefa,
      selecionado: tarefa.id === tarefaSelecionada.id ? true : false
    })))
  }
  return (
    <>
      <div className={style.AppStyle}>
        <Formulario setTarefas={setTarefas} />
        <Lista tarefa={tarefas} selecionaTarefas={selecionaTarefa} />
        <Cronometro selecionado={selecionado}/>
      </div>
    </>
  );
}

export default App;
