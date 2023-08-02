module.exports = (app, texto) => {
    function salvar(req, resp) {
        resp.send("Produto > salvar " + texto)
    }

    function obter(req, resp) {
        resp.send("Produto > obter " + texto)
    }

    app.post("/produto", salvar)
    app.get("/produto", obter)

    return { salvar, obter }
}