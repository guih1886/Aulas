package main

import (
	"F-GO/gin-api-rest/controllers"
	"bytes"
	"encoding/json"
	"gin-api-rest/database"
	"gin-api-rest/models"
	"net/http"
	"net/http/httptest"
	"strconv"
	"testing"

	"github.com/gin-gonic/gin"
	"github.com/stretchr/testify/assert"
)

var ID int

func SetupRotasTeste() *gin.Engine {
	gin.SetMode(gin.TestMode)
	rotas := gin.Default()
	return rotas

}

func CriaAlunoMock() {
	aluno := models.Aluno{Nome: "Aluno Teste", CPF: "12345678911", RG: "123456789"}
	database.DB.Create(&aluno)
	ID = int(aluno.ID)
}

func DeletaAlunoMock() {
	var aluno models.Aluno
	database.DB.Delete(&aluno, ID)
}

/* func TestFalhador(t *testing.T) {
	t.Fatalf("Teste falhou de proposito.")
} */

func TestVerificaStatusCodeDaSaudacaoComParametro(t *testing.T) {
	r := SetupRotasTeste()
	r.GET("/:nome", controllers.Saudacao)
	req, _ := http.NewRequest("GET", "/guilherme", nil)
	resposta := httptest.NewRecorder()
	r.ServeHTTP(resposta, req)
	assert.Equal(t, http.StatusOK, resposta.Code, "Status code deveria ser 200.")
	respostaMock := `{"API diz:":"E ai guilherme, tudo bem?"}`
	assert.Equal(t, respostaMock, resposta.Body.String())
}

func TestListandoTodosAlunosHandler(t *testing.T) {
	database.ConectaComBancoDeDados()
	CriaAlunoMock()
	r := SetupRotasTeste()
	r.GET("/alunos", controllers.ExibeTodosAlunos)
	req, _ := http.NewRequest("GET", "/alunos", nil)
	resposta := httptest.NewRecorder()
	r.ServeHTTP(resposta, req)
	assert.Equal(t, http.StatusOK, resposta.Code)
	defer DeletaAlunoMock()
}

func TestBuscaAlunoPorCpfHnalder(t *testing.T) {
	database.ConectaComBancoDeDados()
	CriaAlunoMock()
	defer DeletaAlunoMock()
	r := SetupRotasTeste()
	r.GET("/alunos/cpf/:cpf", controllers.BuscaAlunoPorCPF)
	req, _ := http.NewRequest("GET", "/alunos/cpf/12345678911", nil)
	resposta := httptest.NewRecorder()
	r.ServeHTTP(resposta, req)
	assert.Equal(t, http.StatusOK, resposta.Code)
}

func TestBuscaAlunoPorIdHandler(t *testing.T) {
	database.ConectaComBancoDeDados()
	CriaAlunoMock()
	defer DeletaAlunoMock()
	r := SetupRotasTeste()
	r.GET("/alunos/:id", controllers.BuscaAlunoPorID)
	path := "/alunos/" + strconv.Itoa(ID)
	req, _ := http.NewRequest("GET", path, nil)
	resposta := httptest.NewRecorder()
	r.ServeHTTP(resposta, req)
	var alunoMock models.Aluno
	json.Unmarshal(resposta.Body.Bytes(), &alunoMock)
	assert.Equal(t, alunoMock.Nome, "Aluno Teste", alunoMock.Nome)
	assert.Equal(t, alunoMock.CPF, "12345678911", alunoMock.CPF)
	assert.Equal(t, alunoMock.RG, "123456789", alunoMock.RG)
	assert.Equal(t, http.StatusOK, resposta.Code)
}

func TestDeletaAlunoHandler(t *testing.T) {
	database.ConectaComBancoDeDados()
	CriaAlunoMock()
	r := SetupRotasTeste()
	r.DELETE("/alunos/:id", controllers.DeletarAlunoPorID)
	path := "/alunos/" + strconv.Itoa(ID)
	req, _ := http.NewRequest("DELETE", path, nil)
	resposta := httptest.NewRecorder()
	r.ServeHTTP(resposta, req)
	assert.Equal(t, http.StatusNoContent, resposta.Code)
}

func TestEditaAlunoHandler(t *testing.T) {
	database.ConectaComBancoDeDados()
	CriaAlunoMock()
	defer DeletaAlunoMock()
	r := SetupRotasTeste()
	r.PATCH("/alunos/:id", controllers.EditarAlunoPorId)
	path := "/alunos/" + strconv.Itoa(ID)
	aluno := models.Aluno{Nome: "Aluno Editado", CPF: "11987654321", RG: "123456789"}
	valorJson, _ := json.Marshal(aluno)
	req, _ := http.NewRequest("PATCH", path, bytes.NewBuffer(valorJson))
	resposta := httptest.NewRecorder()
	r.ServeHTTP(resposta, req)
	var alunoMock models.Aluno
	json.Unmarshal(resposta.Body.Bytes(), &alunoMock)
	assert.Equal(t, "11987654321", alunoMock.CPF)
	assert.Equal(t, "123456789", alunoMock.RG)
	assert.Equal(t, "Aluno Editado", alunoMock.Nome)
	assert.Equal(t, http.StatusOK, resposta.Code)
}
