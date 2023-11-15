import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import Personalidades from './components/Personalidades';

ReactDOM.render(
  <React.StrictMode>
    <App />
    <Personalidades />
  </React.StrictMode>,
  document.getElementById('root')
);
