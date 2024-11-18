String? validaInputNome(String? value) {
  if (value != null && value.isEmpty) {
    return 'Insira um nome válido para a tarefa.';
  }
  return null;
}

String? validaInputDificuldade(String? value) {
  if (value!.isEmpty || int.parse(value) > 5 || int.parse(value) < 1) {
    return 'Insira uma dificuldade entre 1 e 5';
  }
  return null;
}

String? validaInputImagem(String? value) {
  if (value!.trim().isEmpty) {
    return 'Insira uma URL da imagem.';
  }
  return null;
}
