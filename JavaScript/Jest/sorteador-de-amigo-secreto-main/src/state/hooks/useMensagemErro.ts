import { useRecoilValue } from 'recoil';
import { erroState } from '../atom';

export const useMensagemErro = () => {
    const mensagemErro = useRecoilValue(erroState)
    return mensagemErro;
}