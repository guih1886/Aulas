/*select
 e.id as ID,
 e.NOME as Estado,
 c.estado_id as ID,
 c.nome as Cidade
 from
 estados2 e,
 cidades c
 where
 e.id = c.estado_id;*/

 
select
    c.nome as Cidade,
    e.nome as Estado,
    regiao as Região
from
    estados2 e
inner join cidades c on e.id = c.estado_id