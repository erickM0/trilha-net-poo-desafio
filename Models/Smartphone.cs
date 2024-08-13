namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
        //Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        private string Modelo{ get; set; }
        private string IMEI{ get; set; }
        private int Memoria{ get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {

            // Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void MostrarConfigurcoes(){

            // Metodo para exibir configurações (propriedades privadas) do objeto
            // Juntamente com as propriedades privadas, o método utiliza 
            // a classe Object para obter o nome da classe e informar como "Marca"

            Console.WriteLine("Configurações do smartphone:\n\n"+
                              $"Marca: {this.GetType().Name}\n"+
                              $"Modelo: {Modelo}\n"+
                              $"Memoria: {Memoria}GB\n"+
                              $"IMEI: {IMEI}\n");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}