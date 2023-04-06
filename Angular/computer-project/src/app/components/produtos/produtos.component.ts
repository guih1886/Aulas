import { Component, OnInit } from '@angular/core';
import { IProduto, produtos } from './produtos';
import { ProdutoService } from 'src/app/services/produto.service';

@Component({
  selector: 'app-produtos',
  templateUrl: './produtos.component.html',
  styleUrls: ['./produtos.component.less']
})
export class ProdutosComponent implements OnInit {
  list: IProduto[] | undefined;

  constructor(
    private produtosService: ProdutoService
  ) { }

  ngOnInit(): void {
    this.list = this.produtosService.getAll();
  }

}
