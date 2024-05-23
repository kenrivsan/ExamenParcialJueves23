using System.ComponentModel.DataAnnotations;

namespace ExamenParcialJueves23
{
    public class clsLibrosElectronicos :clsLibro
    {
        public string formato {  get; set; }
        public string tamanio { set; get; }
        public clsLibrosElectronicos()
        {
            formato = string.Empty;
            tamanio = string.Empty;
        }
    }
}
