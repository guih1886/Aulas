class SenderIdInvalidException implements Exception {
  String idSender;
  String? message;

  SenderIdInvalidException(
      {required this.idSender, this.message = "Invalid Sender Id."});
}

class ReceiverIdInvalidException implements Exception {
  String? message;

  ReceiverIdInvalidException([this.message = "Invalid Receiver Id."]);
}
