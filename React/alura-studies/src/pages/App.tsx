import { useState } from 'react';
import Cronometro from '../components/Cronometro/Cronometro';
import Formulario from '../components/Formulario';
import Lista from '../components/Lista/Lista';
import style from './App.module.scss';
import { ITarefa } from '../types/tarefa';

function App() {
  const [tarefas, setTarefas] = useState<ITarefa[]>([]);
  return (
    <>
      <div className={style.AppStyle}>
        <Formulario setTarefas={setTarefas} />
        <Lista tarefa={tarefas} />
        <Cronometro />
      </div>
    </>
  );
}

export default App;
