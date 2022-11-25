// Nel progetto csharp-geometria creare le seguenti classi :
// 1 - Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere due metodi:
//     calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
// 2 - Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza
//     con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occupatevi di configurare le sue proprietà di base e altezza
//     (come abbiamo fatto con le nostre auto questa mattina nel programma principale) e stampate a video il perimetro e l’area.
// 3 - Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a
//     stampare le loro proprietà ad esempio con un metodo StampaRettangolo

using Geometria;

// INSTANZA RETTANGOLO 1

Console.WriteLine("Inserisci il nome del rettangolo");
string inputNomeRettangolo = Console.ReadLine();

Console.WriteLine("Inserisci la base del rettangolo");
int inputBase = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del rettangolo");
int inputAltezza = int.Parse(Console.ReadLine());

Rettangolo rettangolo1 = new Rettangolo();
rettangolo1.nomeRettangolo = inputNomeRettangolo;
rettangolo1.baseRettangolo = inputBase;
rettangolo1.altezzaRettangolo = inputAltezza;
rettangolo1.StampaRettangolo();

Console.WriteLine("");

// PROVA METODO StampaRettangolo
Console.WriteLine("PROVA METODO StampaRettangolo");

Rettangolo rettangolo2 = new Rettangolo();
Rettangolo rettangolo3 = new Rettangolo();
Rettangolo rettangolo4 = new Rettangolo();
Rettangolo rettangolo5 = new Rettangolo();

rettangolo2.nomeRettangolo = "RETTANGOLO 2";
rettangolo2.baseRettangolo = 20;
rettangolo2.altezzaRettangolo = 10;
rettangolo2.StampaRettangolo();

rettangolo3.nomeRettangolo = "RETTANGOLO 3";
rettangolo3.baseRettangolo = 5;
rettangolo3.altezzaRettangolo = 10;
rettangolo3.StampaRettangolo();

rettangolo4.nomeRettangolo = "RETTANGOLO 4";
rettangolo4.baseRettangolo = 96;
rettangolo4.altezzaRettangolo = 43;
rettangolo4.StampaRettangolo();

rettangolo5.nomeRettangolo = "RETTANGOLO 5";
rettangolo5.baseRettangolo = 100;
rettangolo5.altezzaRettangolo = 200;
rettangolo5.StampaRettangolo();