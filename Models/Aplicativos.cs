using DesafioPOO.Models.Interface;

namespace DesafioPOO.Models
{
    internal class Aplicativo
    {
        private string _nome;
        

        public string Nome
        {
            get => _nome; set
            {
                _nome = value;
            }
        }
        


        public Aplicativo()
        {
            
        }

        public Aplicativo(string nome)
        {
            Nome = nome;
        
        }

        

        public void ApresentaAplicativo()
        {
            Console.WriteLine($"Nome: {_nome}");
        }
        public void AbriAplicativo()
        {
            Console.WriteLine($"Abrindo {_nome}....");
            Thread.Sleep(1000);
            Console.WriteLine("Abriu");
        }
        public bool DesinstalarAplicativo()
        {
            Console.WriteLine("Tem certeza que deseja desinstalar?");
            string[] opcoesUsuario = { " Sim ", "Não" };
            var opcoes = new ConsoleMenu<string>(opcoesUsuario);
            var selecaoUsario = opcoes.ShowMenu();
            switch (selecaoUsario)
            {
                case 0:
                    Console.WriteLine("Desinstalando...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Abriu");
                    return true;

                case 1:
                    Console.WriteLine("Tudo bem!");
                    return false;
            }

            return false;
        }

    }
}