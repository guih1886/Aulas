namespace ItemService.Dtos
{
    public class RestauranteReadDto
    {
        public int Id { get; set; }
        public int IdExterno { get; set; } // Adicionado

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Site { get; set; }
    }
}