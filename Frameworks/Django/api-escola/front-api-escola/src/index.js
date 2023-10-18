import React from 'react';
import { createRoot } from 'react-dom/client';
import './index.css';
import Appl from './App';

const App = () => {
  return <Appl/>
};

const root = document.getElementById('root');
const reactRoot = createRoot(root);
reactRoot.render(<App />);


