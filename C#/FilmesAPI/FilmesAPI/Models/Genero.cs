using System.ComponentModel.DataAnnotations;

public enum Genero
{
    [Display(Name = "Comédia")]
    COMEDIA,
    [Display(Name = "Romance")]
    ROMANCE,
    [Display(Name = "Drama")]
    DRAMA,
    [Display(Name = "Terror")]
    TERROR,
    [Display(Name = "Suspense")]
    SUSPENSE,
    [Display(Name = "Ficção")]
    FICCAO,
    [Display(Name = "Documentário")]
    DOCUMENTARIO,
}
