/*
 select
 *
 from
 estados.REGIAO
 
 
 select
 nome as 'Nome dos Estados',
 sigla
 from
 estados
 where
 regiao = "Sul"
 */
select
    nome,
    regiao
from
    estados
where
    POPULACAO >= 10
order by
    POPULACAO desc