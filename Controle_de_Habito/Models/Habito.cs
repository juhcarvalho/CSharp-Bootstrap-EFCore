namespace Controle_de_Habito.Models
{
    public class Habito
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Objetivo { get; set; }

        public string Dias { get; set; }

        public DateTime Horario { get; set; }

        public DateTime? DataInicio { get; set; }

    }
}
