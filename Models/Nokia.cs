
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    internal sealed class Nokia : Smartphone
    {
        public Nokia(string numero, string mei, string modelo, int memoria, bool memoriaEhExpansivel) : base(numero, mei, modelo, memoria, memoriaEhExpansivel)
        {
            ListaApps = new List<Aplicativo> { new Aplicativo("GooglePlay"), new Aplicativo("Camera"), new Aplicativo("Telefone"), new Aplicativo("Mensagens") };
        }




        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando app em {Modelo}");
            var app = ListaApps.FirstOrDefault(a => a.Nome == "GooglePlay");
            if (app != null)
            {
                app.AbriAplicativo();
                var aplicativoInstalado = new Aplicativo(nomeApp);
                ListaApps.Add(aplicativoInstalado);
            }
        }
    }
}