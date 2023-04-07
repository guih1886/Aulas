import { Component, OnInit } from '@angular/core';
import { ProdutoService } from 'src/app/services/produto.service';
import { IProduto, IProdutoCarrinho } from '../../produtos/produtos';
import { ActivatedRoute } from '@angular/router';
import { NotificacaoService } from 'src/app/services/notificacao.service';
import { CarrinhoService } from 'src/app/services/carrinho.service';

@Component({
  selector: 'app-detalhe-produto',
  templateUrl: './detalhe-produto.component.html',
  styleUrls: ['./detalhe-produto.component.less']
})
export class DetalheProdutoComponent implements OnInit {
  ngOnInit(): void {
    const routeParams = this.route.snapshot.paramMap
    const produtoId = Number(routeParams.get("id"));
    console.log(produtoId)
    this.produto = this.produtosService.getOne(produtoId);
  }

  produto: IProduto | undefined;
  quantidade = 1;


  constructor(
    private produtosService: ProdutoService,
    private route: ActivatedRoute,
    private notificacaoService: NotificacaoService,
    private carrinhoService: CarrinhoService
  ) { }



  adicionarAoCarrinho() {
    this.notificacaoService.notificar("Produto adicionado ao carrinho.");
    const produto: IProdutoCarrinho = {
      ...this.produto!,
      quantidade: this.quantidade
    }
    this.carrinhoService.adicionarAoCarrinho(produto);
  }

}
