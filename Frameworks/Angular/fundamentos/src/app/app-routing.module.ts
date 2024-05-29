import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PrimeiroComponenteComponent } from './primeiro-componente/primeiro-componente.component';
import { PaginaComParametrosComponent } from './pagina-com-parametros/pagina-com-parametros.component';

const routes: Routes = [
  { path: "primeira-pagina", component: PrimeiroComponenteComponent },
  { path: "pagina-com-parametros/:id", component: PaginaComParametrosComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
