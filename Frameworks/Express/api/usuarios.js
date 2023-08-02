function salvar(req, resp) {
    resp.send("Usuario > Salvar")
}

function obter(req, resp) {
    resp.send("Usuario > Obter")
}

module.exports = { salvar, obter }