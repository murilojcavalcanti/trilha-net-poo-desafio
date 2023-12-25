using DesafioPOO.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    internal class Android : Smartphone
    {
        public Android(string numero, string modelo, string mei, int memoria, bool memoriaEhExpansivel) : base(numero, modelo, mei, memoria, memoriaEhExpansivel)
        {
            ListaApps = new List<Aplicativo> { new Aplicativo("GooglePlay"), new Aplicativo("Camera"), new Aplicativo("Telefone"), new Aplicativo("Mensagens") };
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando app em {Modelo}");
            var app = ListaApps.FirstOrDefault(a=>a.Nome == "GooglePlay");
            if (app != null)
            {
                app.AbriAplicativo();
                var aplicativoInstalado = new Aplicativo(nomeApp);
                ListaApps.Add(aplicativoInstalado);
            }
        }

    }
}
