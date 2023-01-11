<?php

$ficheiro = fopen('teste.txt', 'a'); // w white, a append, r read
fwrite($ficheiro, "Valor");
fclose($ficheiro);

$text = '<p>Ea odio nihil aut officiis minima aut eveniet amet non iste consequatur 33 dolor fugiat. Non esse saepe aut blanditiis dolores qui iusto officiis eos officia tempore sit aliquid architecto aut distinctio distinctio et blanditiis inventore. Nam mollitia consequatur ut ratione cumque in omnis quasi est recusandae internos aut quia magni aut explicabo optio. Eum incidunt enim a omnis velit qui quia pariatur? </p><p>Eum iusto omnis 33 quia sunt sed repudiandae assumenda quo excepturi galisum non sequi amet aut illum nihil aut minus cumque? Et perferendis dignissimos et fugiat dolore ut recusandae voluptatem a tempora recusandae. </p><p>Et enim voluptatem sit reprehenderit aliquid non incidunt repellendus ut praesentium deserunt eos molestias explicabo et officia impedit aut sequi natus. Vel ratione dolores qui sint ducimus quo dolorum sint. Qui deserunt aperiam et iusto dolores rem eaque autem est accusamus impedit aut quia officiis aut placeat cumque. Aut dolorem sint sit quibusdam aspernatur vel animi voluptatibus est vero minus est consequatur pariatur aut libero fuga nam laboriosam inventore? </p>
';

//file_put_contents('texto.txt', $text);

echo file_get_contents('texto.txt');

$paises = file('paises.txt', FILE_SKIP_EMPTY_LINES | FILE_IGNORE_NEW_LINES);
print_r($paises);