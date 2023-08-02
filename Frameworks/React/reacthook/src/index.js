import {createContext} from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './RenderTypes';

export const TreesContext = createContext()

const trees = [
    {
        id: '1', type: 'Maple',
    },
    {
        id: '2', type: 'Oak',
    },
    {
        id: '3', type: 'Family',
    },
    {
        id: '4  ', type: 'Component',
    }
]

console.log(trees)

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <>
    <App />
  </>
);

