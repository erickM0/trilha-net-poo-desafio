namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : 
        base( numero, modelo, imei, memoria)
        {
            
        }


        public override void InstalarAplicativo(string nomeApp)
        {
            // Sobrescrever o método "InstalarAplicativo"
            Console.WriteLine("Metodo instalar aplicativo Iphone:\n"+
                              $"Instalando o app {nomeApp}\n");
        }
        
    }
}