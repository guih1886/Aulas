import { Component, OnInit } from '@angular/core';
import { IProduto } from './produtos';
import { ProdutoService } from 'src/app/services/produto.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-produtos',
  templateUrl: './produtos.component.html',
  styleUrls: ['./produtos.component.less']
})
export class ProdutosComponent implements OnInit {
  list: IProduto[] | undefined;

  constructor(
    private produtosService: ProdutoService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    const produtos = this.produtosService.getAll();
    this.route.queryParamMap.subscribe(params => {
      const descricao = params.get("descricao")?.toLowerCase();
      if (descricao) {
        this.list = produtos.filter(produto => produto.descricao.toLowerCase().includes(descricao))
      }
      this.list = produtos
    })
  }

}
