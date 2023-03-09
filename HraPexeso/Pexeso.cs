using System;
using System.Collections.Generic;
using System.Drawing;

public class Pexeso
{
    Image kryciKarta;
    List<string> poleSouboruDvojic;

    /// <summary>
    /// Konstruktor třídy Pexeso
    /// </summary>
    /// <param name="kryciKarta">vstupní krycí karta</param>
    /// <param name="poleSouboruDvojic">vstupní pole souborů dvojic</param>
    public Pexeso(Image kryciKarta, List<string> poleSouboruDvojic)
    {
        this.kryciKarta = kryciKarta;
        this.poleSouboruDvojic = poleSouboruDvojic;
    }

    /// <summary>
    /// Vytvoří herní pole z polí dvojic karet
    /// </summary>
    /// <param name="pocetDvojic">počet dvojic karet</param>
    /// <returns>vrátí herní pole, složené z dvojic karet</returns>
    private List<Image> HerniPole(int pocetDvojic)
    {
        List<Image> herniPole = new List<Image>();
        List<Image> dvojice = new List<Image>();

        //naplnění pole dvojic
        for (int i = 0; i < pocetDvojic; i++)
        {
            dvojice.Add(Image.FromFile(poleSouboruDvojic[i]));
        }

        //přidělení popisků dvojicím
        for (int i = 0; i < dvojice.Count; i++)
        {
            dvojice[i].Tag = "karta" + i;
        }

        //naplnění herního pole sloučením dvou polí dvojic
        herniPole.AddRange(dvojice);
        herniPole.AddRange(dvojice);
        return herniPole;
    }

    /// <summary>
    /// Tvorba hracího pole
    /// </summary>
    /// <param name="pocetRadku">počet řádků hracího pole</param>
    /// <param name="pocetSloupcu">počet sloupců hracího pole</param>
    /// <returns>vrátí dvourozměrné hrací pole</returns>
    public Image[,] HraciPole(int pocetRadku, int pocetSloupcu)
    {
        Image[,] pole = new Image[pocetRadku, pocetSloupcu];
        Random r = new Random();
        List<Image> herniPole = HerniPole((pocetRadku * pocetSloupcu) / 2);

        for (int i = 0; i < pocetRadku; i++)
        {
            for (int j = 0; j < pocetSloupcu; j++)
            {
                int rnd = r.Next(herniPole.Count);
                pole[i, j] = herniPole[rnd];
                pole[i, j].Tag = herniPole[rnd].Tag;
                herniPole.RemoveAt(rnd);
            }
        }
        return pole;
    }

    /// <summary>
    /// Tvorba krycího pole
    /// </summary>
    /// <param name="pocetRadku">počet řádků</param>
    /// <param name="pocetSloupcu">počet sloupců</param>
    /// <returns>vrátí pole krycích karet</returns>
    public Image[,] KryciPole(int pocetRadku, int pocetSloupcu)
    {
        Image[,] pole = new Image[pocetRadku, pocetSloupcu];
        for (int i = 0; i < pocetRadku; i++)
        {
            for (int j = 0; j < pocetSloupcu; j++)
            {
                pole[i, j] = kryciKarta;
            }
        }
        return pole;
    }
}