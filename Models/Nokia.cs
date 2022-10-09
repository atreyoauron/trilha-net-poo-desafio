namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine($"Instalação do aplicativo {nomeApp} concluida com sucesso");
            Console.WriteLine($"Propriedades do Nokia: ");
            Console.WriteLine($"Numero: {Numero} | Modelo: {Modelo} |IMEI: {Imei} | Memoria: {Memoria} Gigas");

        }
    }
}