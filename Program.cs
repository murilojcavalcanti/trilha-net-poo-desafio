using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

internal class Program
{
    private static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("81957516567", "nokia01", "1981981951", 514, false);
        Smartphone Iphone = new Iphone("81957465676", "Iphone12", "1981981951", 1000, false);
        Smartphone Android = new Android("81751685679", "S02", "1981981951", 612, true);

        
        nokia.RealizaLigacao();
        nokia.InstalarAplicativo("Instagram");
        
        Thread.Sleep(3000);

        nokia.ApresentaApps();
        nokia.ReceberLigacao();
        Thread.Sleep(3000);
        nokia.AbreApp();

        Console.WriteLine("==== Iphone ==== ");
        Iphone.RealizaLigacao();
        Iphone.InstalarAplicativo("Facebook");
        Thread.Sleep(3000);
        Iphone.ApresentaApps();
        Iphone.ReceberLigacao();
        Thread.Sleep(3000);
        Iphone.AbreApp();

        Console.WriteLine("==== Android ==== ");
        Android.RealizaLigacao();
        Android.InstalarAplicativo("Olx");
        Thread.Sleep(3000);
        Android.ApresentaApps();
        Android.ReceberLigacao();
        Thread.Sleep(3000);
        Android.AbreApp();

    }
}