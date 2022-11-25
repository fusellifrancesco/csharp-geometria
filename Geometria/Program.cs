// Nel progetto csharp-geometria creare le seguenti classi :
// 1 - Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere due metodi:
//     calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
// 2 - Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza
//     con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occupatevi di configurare le sue proprietà di base e altezza
//     (come abbiamo fatto con le nostre auto questa mattina nel programma principale) e stampate a video il perimetro e l’area.
// 3 - Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a
//     stampare le loro proprietà ad esempio con un metodo StampaRettangolo

using Geometria;

Console.WriteLine("Inserisci il nome del rettangolo");
string inputNomeRettangolo = Console.ReadLine();

Console.WriteLine("Inserisci la base del rettangolo");
int inputBase = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del rettangolo");
int inputAltezza = int.Parse(Console.ReadLine());

Rettangolo rettangolo1 = new Rettangolo();
rettangolo1.baseRettangolo = inputBase;
rettangolo1.altezzaRettangolo = inputAltezza;

Console.Write("L'Area del rettangolo è: ");
Console.WriteLine(rettangolo1.CalcolaArea() + " cm2");

Console.Write("Il Perimetro del rettangolo è: ");
Console.WriteLine(rettangolo1.CalcolaPerimetro() + " cm");