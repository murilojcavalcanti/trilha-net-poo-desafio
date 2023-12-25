using DesafioPOO.Models.Interface;

namespace DesafioPOO.Models
{
    internal abstract class Smartphone
    {
        private string numero;

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string modelo;
        private string mei;
        private int memoria;
        private bool memoriaEhExpasivel;
        protected List<Aplicativo> ListaApps;
        public string Numero { get => numero;private set=>numero = value; }
        protected string Modelo { get => modelo; private set => modelo = value; }
        protected string Mei { get => mei; private set => mei = value; }
        protected int Memoria { get => memoria; private set => memoria = value; }
        protected bool MemoriaEhExpasivel { get => memoriaEhExpasivel; private set => memoriaEhExpasivel = value; }

        public Smartphone(string numero, string modelo, string mei, int memoria, bool memoriaEhExpansivel)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Mei = mei;
            Memoria = memoria;
            MemoriaEhExpasivel = memoriaEhExpansivel;
        }

        public void Ligar()
        {

            Console.WriteLine($"Ligando em {Modelo} ...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação em {Modelo}...");
        }
        public void RealizaLigacao()
        {
            Console.WriteLine($"ligando em {Modelo}...");
        }

        public void ApresentaApps()
        {
            foreach (var item in ListaApps)
            {
                item.ApresentaAplicativo();
            }
        }

        public void AbreApp()
        {
            string[] apps = ListaApps.Select(item => $"\n- APP: {item.Nome} ").ToArray();
            var opcoes = new ConsoleMenu<string>(apps);
            Console.WriteLine($"Abrindo app em {modelo}");

            var selecaoUsario = opcoes.ShowMenu();
            Aplicativo app = ListaApps[selecaoUsario];
            app.AbriAplicativo();
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}