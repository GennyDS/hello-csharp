// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine();
string[] mesi = {"Gennaio","Febbraio","Marzo","Aprile","Maggio","Giugno","Luglio","Agosto","Settembre","Ottobre","Novembre","Dicembre" };
string mesePreferito;
for (int i = 0; i < mesi.Length; i++)
{ 
Console.WriteLine(mesi[i]);
}
Console.WriteLine();
Console.WriteLine("Qual è il tuo mese preferito ?");
mesePreferito= Console.ReadLine();
Console.WriteLine("il tuo mese preferito è: " +mesePreferito);
Console.WriteLine();
Console.WriteLine("ARRIVEDERCI !!!");