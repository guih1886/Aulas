using Newtonsoft.Json;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cep
    {
        public class Unit
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Localidade { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string UF { get; set; }
            public string Unidade { get; set; }
            public string IBGE { get; set; }
            public string GIA { get; set; }
        }

        public static Unit DesSerializeClassUnit(string json)
        {
            return JsonConvert.DeserializeObject<Unit>(json);
        }

        public static string SerializeClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
