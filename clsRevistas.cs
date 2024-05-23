namespace ExamenParcialJueves23
{
    public class clsRevistas : clsLibro
    {
        public string Volumen {  get; set; }
        public int Numero {  get; set; }
        public clsRevistas()
        {
            Volumen = string.Empty;
            Numero = 0;
        }
    }
}
