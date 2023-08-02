select
    REGIAO as 'Região',
    sum(POPULACAO) as Total
    from `estados2`
    GROUP BY regiao
    order by total desc
