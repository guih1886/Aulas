/* insert into
 cidades (nome, area, estado_id)
 values
 ('Campinas', 795, 21),
 ('Niterói', 133.9, 15) */
insert into
    cidades (nome, area, estado_id)
values
    ('Cauaru', 920.6, (select id from `estados2` where SIGLA = 'PE'))