using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnUnesi_Click(object sender, EventArgs e)
        {
            String ime = txbIme.Text;
            String adresa = txbAdresa.Text;

            jeJednaRec(ime);
            jeJednaRec(adresa);

            MessageBox.Show("Ime je: " + ime + ",\nAdresa je: " + adresa);

            string fileName = @"C:\Temp\CS322-DZ02.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(ime);
                    writer.WriteLine(adresa);
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }

        private static void jeJednaRec(string text)
        {
            
            if (!text.Trim(' ').Contains(" "))
            {
                MessageBox.Show(text + ": je jedna rec!");
            }
            else
            {
                MessageBox.Show(text + ": nije jedna rec!");
            }
        }

    }
}
