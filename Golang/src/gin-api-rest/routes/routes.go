package routes

import (
	"F-GO/gin-api-rest/controllers"

	"github.com/gin-gonic/gin"
)

func HandleRequests() {
	r := gin.Default()
	r.LoadHTMLGlob("templates/*")
	r.Static("/assets", "./assets")
	r.GET("/alunos", controllers.ExibeTodosAlunos)
	r.GET("/alunos/:id", controllers.BuscaAlunoPorID)
	r.GET("/alunos/cpf/:cpf", controllers.BuscaAlunoPorCPF)
	r.GET("/:nome", controllers.Saudacao)
	r.POST("/alunos", controllers.CriaNovoAluno)
	r.PATCH("/alunos/:id", controllers.EditarAlunoPorId)
	r.DELETE("/alunos/:id", controllers.DeletarAlunoPorID)
	r.GET("/index", controllers.ExibePaginaIndex)
	r.NoRoute(controllers.ExibePagina404)
	r.Run()
}
