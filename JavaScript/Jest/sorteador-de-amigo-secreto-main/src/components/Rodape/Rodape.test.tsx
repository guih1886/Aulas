import { fireEvent, render, screen } from "@testing-library/react"
import { RecoilRoot } from "recoil"
import Rodape from "./Rodape"
import { useListaDeParticipantes } from "../../state/hooks/useListaDeParticipantes"

const mockNavegacao = jest.fn()
const mockSorteador = jest.fn()

jest.mock("../../state/hooks/useListaDeParticipantes", () => {
    return {
        useListaDeParticipantes: jest.fn()
    }
})


jest.mock("react-router-dom", () => {
    return {
        useNavigate: () => mockNavegacao
    }
})

jest.mock("../../state/hooks/useSorteador", () => {
    return {
        useSorteador: () => mockSorteador
    }
})
describe("quando nao existem participantes suficientes", () => {
    beforeEach(() => {
        (useListaDeParticipantes as jest.Mock).mockReturnValue([])
    })
    test("a brincadeira nao pode ser iniciada", () => {
        render(
            <RecoilRoot>
                <Rodape />
            </RecoilRoot>
        )
        const botao = screen.getByRole('button')
        expect(botao).toBeDisabled()
    })
})

describe("quando existem participantes suficientes", () => {
    beforeEach(() => {
        (useListaDeParticipantes as jest.Mock).mockReturnValue(['ana', 'catarina', 'josefina'])
    })
    test("a brincadeira pode ser iniciada", () => {
        render(
            <RecoilRoot>
                <Rodape />
            </RecoilRoot>
        )
        const botao = screen.getByRole('button')
        expect(botao).not.toBeDisabled()
    })
    test("a brincadeira foi iniciada", () => {
        render(
            <RecoilRoot>
                <Rodape />
            </RecoilRoot>
        )
        const botao = screen.getByRole('button')
        fireEvent.click(botao)
        expect(mockNavegacao).toHaveBeenCalled()
        expect(mockNavegacao).toBeCalledWith("/sorteio")
        expect(mockSorteador).toBeCalledTimes(1)
    })
})