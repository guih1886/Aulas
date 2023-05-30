import { useEffect, useState } from 'react';
import IRestaurante from '../../interfaces/IRestaurante';
import style from './ListaRestaurantes.module.scss';
import Restaurante from './Restaurante';
import axios from 'axios';
import { IPaginacao } from '../../interfaces/IPaginacao';

const ListaRestaurantes = () => {

  const [restaurantes, setRestaurantes] = useState<IRestaurante[]>([]);
  const [proximaPagina, setProximaPagina] = useState("");

  useEffect(() => {
    axios.get<IPaginacao<IRestaurante>>("http://192.168.200.105:8000/api/v1/restaurantes/").then(resp => {
      setRestaurantes(resp.data.results)
      setProximaPagina(resp.data.next)
    }).catch(e => { console.log(e) });
  }, [])

  const vermais = () => {
    axios.get<IPaginacao<IRestaurante>>(proximaPagina).then(resp => {
      setRestaurantes([...restaurantes, ...resp.data.results])
      setProximaPagina(resp.data.next)
    })
  }

  return (<section className={style.ListaRestaurantes}>
    <h1>Os restaurantes mais <em>bacanas</em>!</h1>
    {restaurantes?.map(item => <Restaurante restaurante={item} key={item.id} />)}
    {proximaPagina && <button onClick={vermais}>ver mais</button>}
  </section>)
}

export default ListaRestaurantes