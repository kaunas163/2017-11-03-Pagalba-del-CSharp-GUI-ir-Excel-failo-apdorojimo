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

namespace Excel_automobiliai_apdorojimas
{
    public partial class Form1 : Form
    {
        public List<Automobilis> Automobiliai { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Automobiliai = new List<Automobilis>();
        }

        private void išeitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiFailąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog failas = new OpenFileDialog();
            failas.Filter = "csv failas (*.csv)|*.csv";

            if (failas.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    /*if ((myStream = failas.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }*/

//                    MessageBox.Show(failas.FileName);

                    Nuskaityti(failas.FileName);
                    dataGridView1.DataSource = Automobiliai;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida: nepavyko nuskaityti failo. " + ex.Message);
                }
            }
        }

        private void Nuskaityti(string failas)
        {
            using (StreamReader sr = new StreamReader(failas))
            {
                string eilute;
                
                while ((eilute = sr.ReadLine()) != null)
                {
//                    MessageBox.Show(eilute);

                    var isskaidyta = eilute.Split(';');

                    var marke = isskaidyta[0];
                    var modelis = isskaidyta[1];
                    var metai = Convert.ToInt32(isskaidyta[2]);
                    var rida = Convert.ToInt32(isskaidyta[3]);
                    var auto = new Automobilis(marke, modelis, metai, rida);
                    Automobiliai.Add(auto);
                }
            }
        }

        private void atliktiSkaičiavimusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new SkaiciavimaiForm(Automobiliai);
            forma.ShowDialog();
        }
    }
}
