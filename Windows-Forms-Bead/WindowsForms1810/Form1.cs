using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1810
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            saveFileDialog1.FileOk += (senderFile, eFile) =>//MILYEN FORMÁTUMBA MENTSE
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;//FÁJL ELNEVEZÉSÉHEZ SZÜKSÉGES VÁLTOZÓ
                    // File.WriteAllLines(fileNeme, Adatok.Items.Cast<string>().ToArray());//BEÍRJUK A LISTÁBA A SOROKAT
                    StreamWriter sw = new StreamWriter(fileName);
                    sw.Write(tbNev.Text+ ";");
                    sw.Write(tbSzuldatum.Text + ";");
                    if (radioFerfi.Checked)
                    {
                        sw.Write("Férfi"+";");
                    }
                    if (radioNo.Checked)
                    {
                        sw.Write("Nő" + ";");
                    }
                    sw.Write(Adatok.SelectedItem+";");
                    foreach (var item in Adatok.Items)
                    {
                        sw.Write(item + ".");
                    }
                    sw.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba, nem sikerült a kiírás.");
                }
            };

            //AJÁNLATOS OLYAN FORMÁTUMOT ADNI, AMIVEL DOLGOZUNK, VAGY KERESSÜK, VAGY *.*, HOGY FEL TUDJUK BÍRÁLNI
            openFileDialog1.FileOk += (sender, e) =>
            {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    try
                    {
                        string olvas = sr.ReadLine();
                        string[] st = olvas.Split(';');
                        tbNev.Text = st[0];
                        tbSzuldatum.Text = st[1];
                        if (st[2]=="Férfi")
                        {
                            radioFerfi.Checked = true;
                        }
                        else
                        {
                            radioNo.Checked = true;
                        }
                    ;
                    string[] hobbi = st[4].Split('.');
                    Adatok.Items.Clear();

                    for (int i = 0; i < hobbi.Length; i++)
                    {
                        Adatok.Items.Add(hobbi[i]);
                        if (st[3] == hobbi[i])
                        {
                            Adatok.SelectedItem= hobbi[i];
                        }
                    }

                    sr.ReadLine();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Hiba! Sikertelen betöltés.");
                    }
            };
        }


        //ELŐUGRIK A MENTÉS-BETÖLTÉS FELÜLETE 
        private void buttonMentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();//HOVA MENTSE
            saveFileDialog1.Dispose();
        }

        private void buttonBetolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//MIT TÖLTSÜNK BE
            openFileDialog1.Dispose();
        }


       
        //A KIVÁLASZTOTTAKAT HOZZÁADJUK A LISTÁHOZ

        private void btUjhobbi(object sender, KeyEventArgs e)//ENTERRE
        {
            if (e.KeyCode == Keys.Enter)
            {
                Adatok.Items.Add(tbUjhobbi.Text);//ENTER LENYOMÁSÁRA A LISTÁBA KERÜL A BOX-BA ÍRT SZÖVEG
                tbUjhobbi.Text = "";//ÜRESEN FŰZI HOZZÁ ENTER LENYOMÁSA UTÁN, HA NEM LENNE, AKKOR MEGMARAD AZ ELŐZŐ BEÍRT SZÖVEG
            }
        }

        private void buttonHozzaad_Click(object sender, EventArgs e)//HOZZÁADRA KLIKK
        {
            if (tbUjhobbi.Text != "")
            {
                Adatok.Items.Add(tbUjhobbi.Text);//HOZZÁADÁSRA A LISTÁBA KERÜL A BOX-BA ÍRT HOBBI(MINT AZ ENTER, CSAK KLIKKRE)
                tbUjhobbi.Text = "";
            }
        }



        //MEGHÍVÁS
        
        private void tbNev_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbSzuldatum_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioFerfi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Hobbik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kivalaszt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
