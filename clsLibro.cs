namespace ExamenParcialJueves23
{
    public class clsLibro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public DateTime AnioPubli { get; set;}

        public clsLibro()
        {
            
            Titulo = string.Empty;
            Autor = string.Empty;   
            Genero = string.Empty;
            AnioPubli = DateTime.Now;
        }
    }
}
