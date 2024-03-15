using UsuarioLib;

List<Usuario> usuarios = new List<Usuario>();

Usuario usuario =
    new Usuario(
        "Daniel",
        "daniel@email.com",
        new List<string>() { "12345678" });

Usuario usuario2 =
    new Usuario(
        "Luis",
        "luis@email.com",
        new List<string>() { "87654321" });

usuarios.Add(usuario);
usuarios.Add(usuario2);

usuarios.ForEach(usuario => usuario.ExibeTelefones());
usuarios.ForEach(usuario => usuario.PadronizaTelefones());
usuarios.ForEach(usuario => usuario.ExibeTelefones());