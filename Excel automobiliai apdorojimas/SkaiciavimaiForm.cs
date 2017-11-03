using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_automobiliai_apdorojimas
{
    public partial class SkaiciavimaiForm : Form
    {
        public List<Automobilis> Automobiliai { get; private set; }

        public SkaiciavimaiForm(List<Automobilis> automobiliai)
        {
            InitializeComponent();
            Automobiliai = automobiliai;
        }

        private void SkaiciavimaiForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = RidosVidurkis().ToString();
        }

        public double RidosVidurkis()
        {
            var vidurkis = 0.0;

            foreach (var auto in Automobiliai)
            {
                vidurkis += auto.Rida;
            }

            vidurkis /= Automobiliai.Count;
            return vidurkis;
        }
    }
}
