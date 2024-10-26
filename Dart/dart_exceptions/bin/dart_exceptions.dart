import 'controllers/bank_controller.dart';
import 'exceptions/bank_controller_exceptions.dart';
import 'models/account.dart';

void main() {
  // Criando o banco
  BankController bankController = BankController();

  // Adicionando contas
  bankController.addAccount(
      id: "Ricarth",
      account:
          Account(name: "Ricarth Lima", balance: 400, isAuthenticated: true));

  bankController.addAccount(
      id: "Kako",
      account:
          Account(name: "Caio Couto", balance: 600, isAuthenticated: true));


  // Fazendo transferência
  try {
    bool result = bankController.makeTransfer(
        idSender: "Kako2", idReceiver: "Ricarth", amount: 700);

  } on SenderIdInvalidException catch (exception) {
    print(exception.message);
    print(exception.idSender);
  }
  on ReceiverIdInvalidException catch (exception) {
    print(exception.message);
  } finally {}
}
