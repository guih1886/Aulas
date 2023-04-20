import User from './User.mjs'
import Docente from './Docente.mjs'
import Admin from './Admin.mjs'

const novoAdmin = new Admin("Guilherme", "r@r.com", "01/01/2001")
//console.log(novoAdmin);
//console.log(novoAdmin.exibirInfos());
console.log(novoAdmin.criarCurso("JavaScript", 20));


const novoDocente = new Docente("Mariana", "mari@gmail.com", "2001-05-25")
//console.log(novoDocente);
//console.log(novoDocente.exibirInfos());
console.log(novoDocente.aprovaEstudante("Pedro", "PY"));

//encapsulando o código e exibindo
//console.log(novoAdmin);
console.log(novoAdmin.exibirInfos());

//acessa o nome pelo getter, nao pela proprieddade
novoAdmin.nome = "Maria" //trocou atraves do setter para maria
console.log(novoAdmin.nome);
console.log(novoAdmin.exibirInfos());