package routes

import (
	"F-GO/api-go-rest/controllers"
	"F-GO/api-go-rest/middleware"
	"log"
	"net/http"

	"github.com/gorilla/mux"
)

func HandleRequest() {
	r := mux.NewRouter()
	r.Use(middleware.ContentTypeMiddleware)
	r.HandleFunc("/", controllers.Home)
	r.HandleFunc("/api/personalidades", controllers.TodasPersonalidades).Methods("Get")
	r.HandleFunc("/api/personalidades/{id}", controllers.BuscaPersonalidade).Methods("Get")
	r.HandleFunc("/api/personalidades/{id}", controllers.ExcluirPersonalidade).Methods("Delete")
	r.HandleFunc("/api/personalidades/{id}", controllers.EditarPersonalidade).Methods("PUT")
	r.HandleFunc("/api/personalidades", controllers.CadastrarPersonalidade).Methods("Post")
	log.Fatal(http.ListenAndServe(":8000", r))
}
