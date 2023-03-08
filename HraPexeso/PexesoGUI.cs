using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class PexesoGUI
{
    int casZakryti, pocetRadku, pocetSloupcu;
    static Image kryciKarta;
    PictureBox[,] hraciPoleGUI;
    PictureBox[] poleGUI;
    PictureBox prvniVyber, druhyVyber;
    Timer casovac = new Timer();

    /// <summary>
    /// Konstruktor třídy PexesoGUI
    /// </summary>
    /// <param name="casZakryti">čas na opětovné zakrytí zvolené karty v milisekundách</param>
    /// <param name="pocetRadku">počet řádků</param>
    /// <param name="pocetSloupcu">počet sloupců</param>
    public PexesoGUI(int pocetRadku, int pocetSloupcu, int casZakryti)
    {
        this.pocetRadku = pocetRadku;
        this.pocetSloupcu = pocetSloupcu;
        this.casZakryti = casZakryti;
    }

    /// <summary>
    /// Vytvoří hrací pole v GUI
    /// </summary>
    /// <param name="poleGUI">vstupní pole z GUI</param>
    /// <param name="kryciPole">vstupní krycí pole</param>
    /// <param name="hraciPole">vstupní hrací pole</param>
    private void HraciPoleGUI(PictureBox[] poleGUI, Image[,] kryciPole, Image[,] hraciPole)
    {
        hraciPoleGUI = new PictureBox[pocetRadku, pocetSloupcu];

        //tvorba dvourozměrného pole obrázků v GUI
        for (int i = 0; i < pocetRadku; i++)
        {
            for (int j = 0; j < pocetSloupcu; j++)
            {
                hraciPoleGUI[i, j] = poleGUI[i * pocetSloupcu + j];
                hraciPoleGUI[i, j].Image = kryciPole[i, j];
                hraciPoleGUI[i, j].BackgroundImage = hraciPole[i, j];
                hraciPoleGUI[i, j].Tag = hraciPole[i, j].Tag;
            }
        }
    }

    /// <summary>
    /// Kontrola, zda hráč vyhrál
    /// </summary>
    /// <param name="hraciPole">vstupní hrací pole z GUI</param>
    private void KontrolaVyhry(PictureBox[,] hraciPole)
    {
        foreach (PictureBox pb in hraciPole)
        {
            if (pb != null)
            {
                if (pb.Image == kryciKarta)
                    return;
            }
        }
        //výherní gratulace
        MessageBox.Show("Vyhrál/a jste", "Gratulace", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Přiřazení události kliknutí ke všem kartám
    /// </summary>
    /// <param name="poleGUI">vstupní pole z GUI</param>
    private void KliknutiNaKarty(PictureBox[] poleGUI)
    {
        foreach (PictureBox obrazek in poleGUI)
        {
            obrazek.Click += PictureBox_Click;
        }
    }

    /// <summary>
    /// Událost kliknutí na kartu
    /// </summary>
    /// <param name="sender">zvolená karta</param>
    /// <param name="e"></param>
    private void PictureBox_Click(object sender, EventArgs e)
    {
        PictureBox obrazek = (PictureBox)sender;

        if (obrazek != null)
        {
            if (obrazek.Image == null)
                return;

            if (prvniVyber == null)
            {
                prvniVyber = obrazek;
                prvniVyber.Image = null;
                prvniVyber.Tag = obrazek.Tag;
                return;
            }

            druhyVyber = obrazek;
            druhyVyber.Image = null;
            druhyVyber.Tag = obrazek.Tag;

            if (prvniVyber.Tag == druhyVyber.Tag)
            {
                KontrolaVyhry(hraciPoleGUI);
                prvniVyber = null;
                druhyVyber = null;
                return;
            }

            casovac.Start();
        }
    }

    /// <summary>
    /// Událost časovače po kliknutí na kartu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Timer_Tick(object sender, EventArgs e)
    {
        casovac.Stop();
        prvniVyber.Image = kryciKarta;
        druhyVyber.Image = kryciKarta;

        prvniVyber = null;
        druhyVyber = null;
    }

    /// <summary>
    /// Vytvoří pole souborů dvojic
    /// </summary>
    /// <returns>vrátí pole souborů dvojic</returns>
    private List<string> PoleSouboruDvojic()
    {
        List<string> poleSouboru = new List<string>();
        for (int i = 0; i < (pocetRadku * pocetSloupcu / 2); i++)
        {
            if (File.Exists("obr\\" + i + ".jpg"))
            {
                poleSouboru.Add("obr\\" + i + ".jpg");
            }
        }
        return poleSouboru;
    }

    /// <summary>
    /// Vytvoří a následně zobrazí herní okno
    /// </summary>
    /// <param name="titulek">titulek herního okna</param>
    /// <param name="velikostKarty">velikost karty v pixelech</param>
    private void ZobrazitHerniOkno(string titulek, bool zmenaVelikosti, bool minimalizace, bool maximalizace, int velikostKarty)
    {
        Form form = new Form();
        TableLayoutPanel panel = new TableLayoutPanel();

        form.Text = titulek;
        form.ClientSize = new Size(pocetRadku * velikostKarty, pocetSloupcu * velikostKarty);

        //pohyblivá velikost
        if (zmenaVelikosti == true)
            form.FormBorderStyle = FormBorderStyle.Sizable;
        //pevná velikost
        else if (zmenaVelikosti == false)
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
        //možnost minimalizace
        if (minimalizace == false)
            form.MinimizeBox = false;
        //možnost maximalizace
        if (maximalizace == false)
            form.MaximizeBox = false;

        form.StartPosition = FormStartPosition.CenterScreen;
        form.Load += Form_Load;

        panel.AutoSize = true;
        panel.Dock = DockStyle.Fill;
        panel.ColumnCount = pocetRadku;
        panel.RowCount = pocetSloupcu;

        for (int i = 0; i < pocetRadku; i++)
        {
            for (int j = 0; j < pocetSloupcu; j++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (pocetRadku * 100F) / form.Width));
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, (pocetSloupcu * 100F) / form.Height));
                panel.Controls.Add(new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.StretchImage, BackgroundImageLayout = ImageLayout.Stretch }, i, j);
            }
        }

        form.Controls.Add(panel);
        poleGUI = panel.Controls.OfType<PictureBox>().ToArray();
        form.ShowDialog();
    }

    /// <summary>
    /// Událost po načtení herního okna
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form_Load(object sender, EventArgs e)
    {
        kryciKarta = Image.FromFile("obr\\vrsek.jpg");
        Pexeso pexeso = new Pexeso(kryciKarta, PoleSouboruDvojic());
        casovac.Interval = casZakryti;
        casovac.Tick += Timer_Tick;
        KliknutiNaKarty(poleGUI);
        HraciPoleGUI(poleGUI, pexeso.KryciPole(pocetRadku, pocetSloupcu), pexeso.HraciPole(pocetRadku, pocetSloupcu));
    }

    /// <summary>
    /// Zahájí hru Pexeso
    /// </summary>
    /// <param name="titulek">název herního okna</param>
    /// <param name="zmenaVelikosti">možnost ruční změny velikosti okna</param>
    /// <param name="minimalizace">zobrazení tlačítka minimalizace</param>
    /// <param name="maximalizace">zobrazení tlačítka maximalizace</param>
    /// <param name="velikostKarty">velikost karty v pixelech</param>
    public void ZahajitHru(string titulek, bool zmenaVelikosti, bool minimalizace, bool maximalizace, int velikostKarty)
    {
        if (File.Exists("obr\\vrsek.jpg"))
        {
            //kontrola zda byl zadán správný počet dvojic
            if ((pocetRadku * pocetSloupcu % 2) == 0)
            {
                //kontrola zda je dostatečný počet souborů dvojic
                if (PoleSouboruDvojic().Count == (pocetRadku * pocetSloupcu / 2))
                {
                    //vytvoření a zobrazení herního okna
                    ZobrazitHerniOkno(titulek, zmenaVelikosti, minimalizace, maximalizace, velikostKarty);
                }
                else
                {
                    MessageBox.Show("Nebyl nalezen dostatečný počet souborů dvojic", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Nápověda pro správné pojmenování\n\n" +
                        "- složka \'obr\' musí být ve stejné složce jako aplikace\n" +
                        "- soubory musí mít název \'0.jpg\' až \'7.jpg\' pro 8 dvojic atd.\n" +
                        "- soubory musí být umístěny ve složce \'obr\'", "Informace", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nesprávný počet dvojic", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Počet řádků a sloupců musí být dvojnásobkem počtu dvojic", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Nebyl nalezen soubor krycí karty", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Nápověda pro správné pojmenování\n\n" +
                        "- složka \'obr\' musí být ve stejné složce jako aplikace\n" +
                        "- soubor musí mít název \'vrsek.jpg\'\n" +
                        "- soubor musí být umístěn ve složce \'obr\'", "Informace",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}