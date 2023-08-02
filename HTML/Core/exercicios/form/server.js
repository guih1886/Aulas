const express = require('express')
const app = express()
const bodyparser = require('body-parser')


app.use(bodyparser.urlencoded({extended: true}))

app.post('/usuarios', (req, resp) =>{
    console.log(req.body)
    resp.send('Parabéns, usuário incluido.')
})

app.post('/usuarios/:id', (req, resp) =>{
    console.log(req.params.id)
    console.log(req.body)
    resp.send('Parabéns, usuário alterado.')
})

app.listen(5500)
