using bytebank.Modelos.Conta;
using static bytebank.Exceptions.Exceptions;

namespace ByteBank.Atendimento;

public class ByteBankAtendimento
{
    List<ContaCorrente> _listaDeContas = new List<ContaCorrente>() {
    new ContaCorrente(95, "123456-X") {Saldo=100},
    new ContaCorrente(98, "951258-X") {Saldo=200},
    new ContaCorrente(94, "987321-W") {Saldo=60},
    new ContaCorrente(94, "987321-W") {Saldo=70}
};

    List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};


    public void AtendimentoCliente()
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
                switch (opcao)
                {
                    case '1':
                        CadastrarConta();
                        break;
                    case '2':
                        ListarContas();
                        break;
                    case '3':
                        RemoverContas();
                        break;
                    case '4':
                        OrdenarContas();
                        break;
                    case '5':
                        PesquisarConta();
                        break;
                    case '6':
                        break;
                    default:
                        Console.WriteLine("Opcao não implementada.");
                        Console.ReadKey();
                        break;
                }
            }
            catch (ByteBankException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

    void PesquisarConta()
    {

        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===    PESQUISAR CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ou (3) Número da Agencia? ");
        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                {
                    Console.Write("Informe o número da Conta: ");
                    string _numeroConta = Console.ReadLine();
                    ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                    Console.WriteLine(consultaConta);
                    Console.ReadKey();
                    break;
                }
            case 2:
                {
                    Console.Write("Informe o CPF do Titular: ");
                    string _cpf = Console.ReadLine();
                    ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                    Console.WriteLine(consultaCpf);
                    Console.ReadKey();
                    break;
                }
            case 3:
                {
                    Console.Write("Informe o Nº da agência: ");
                    int _numeroAgencia = int.Parse(Console.ReadLine());
                    List<ContaCorrente> consultaAgencia = ConsultaPorNumeroAgencia(_numeroAgencia);
                    foreach (var item in consultaAgencia)
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                    break;
                }
            default:
                Console.WriteLine("Opção não implementada.");
                break;
        }
    }

    List<ContaCorrente> ConsultaPorNumeroAgencia(int numeroAgencia)
    {
        return _listaDeContas.Where(conta => conta.Numero_agencia == numeroAgencia).ToList();
    }

    ContaCorrente ConsultaPorCPFTitular(string cpf)
    {
        return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
    }

    ContaCorrente ConsultaPorNumeroConta(string numeroConta)
    {
        return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
    }

    void OrdenarContas()
    {
        _listaDeContas.Sort();
        Console.WriteLine("... Lista de Contas ordenadas! ...");
        Console.ReadKey();
    }

    void RemoverContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===      REMOVER CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.Write("Informe o número da Conta: ");
        string numeroConta = Console.ReadLine();
        ContaCorrente conta = null;
        foreach (var item in _listaDeContas)
        {
            if (item.Conta.Equals(numeroConta))
            {
                conta = item;
            }
        }
        if (conta != null)
        {
            _listaDeContas.Remove(conta);
            Console.WriteLine("... Conta removida da lista! ...");
        }
        else
        {
            Console.WriteLine(" ... Conta para remoção não encontrada ...");
        }
        Console.ReadKey();
    }
    void ListarContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===     LISTA DE CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        if (_listaDeContas.Count <= 0)
        {
            Console.WriteLine("... Não há contas cadastradas! ...");
            Console.ReadKey();
            return;
        }
        foreach (ContaCorrente item in _listaDeContas)
        {
            Console.WriteLine(item);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }
        Console.ReadKey();
    }

    void CadastrarConta()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===   CADASTRO DE CONTAS    ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("=== Informe dados da conta ===");
        Console.Write("Número da conta: ");
        string numeroConta = Console.ReadLine();

        Console.Write("Número da Agência: ");
        int numeroAgencia = int.Parse(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

        Console.Write("Informe o saldo inicial: ");
        conta.Saldo = double.Parse(Console.ReadLine());

        Console.Write("Infome nome do Titular: ");
        conta.Titular.Nome = Console.ReadLine();

        Console.Write("Infome CPF do Titular: ");
        conta.Titular.Cpf = Console.ReadLine();

        Console.Write("Infome Profissão do Titular: ");
        conta.Titular.Profissao = Console.ReadLine();

        _listaDeContas.Add(conta);
        Console.WriteLine("... Conta cadastrada com sucesso! ...");
        Console.ReadKey();
    }


}
