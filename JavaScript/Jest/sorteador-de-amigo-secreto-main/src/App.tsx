import React from 'react'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import { RecoilRoot } from 'recoil'
import Configuracao from './pages/Configuracao'
import Sorteio from './pages/Sorteio/Sorteio'

export default function App() {
  return (
    <BrowserRouter>
      <RecoilRoot>
        <Routes >
          <Route path='/' element={<Configuracao />} />
          <Route path='/sorteio' element={<Sorteio />} />
        </Routes >
      </RecoilRoot>
    </BrowserRouter>
  )
}