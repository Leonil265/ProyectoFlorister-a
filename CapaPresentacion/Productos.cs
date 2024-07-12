using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void cboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxColor.SelectedIndex != -1) 
            { 
                if (cboxColor.SelectedIndex == 0)
                    panelColor.BackColor = Color.Yellow;
                if (cboxColor.SelectedIndex == 1)
                    panelColor.BackColor = Color.DarkOrange;
                if (cboxColor.SelectedIndex == 2)
                    panelColor.BackColor = Color.Red;
                if (cboxColor.SelectedIndex == 3)
                    panelColor.BackColor = Color.HotPink;
                if (cboxColor.SelectedIndex == 4)
                    panelColor.BackColor = Color.DarkViolet;
                if (cboxColor.SelectedIndex == 5)
                    panelColor.BackColor = Color.LightSkyBlue;
                if (cboxColor.SelectedIndex == 6)
                    panelColor.BackColor = Color.LimeGreen;
                if (cboxColor.SelectedIndex == 7)
                    panelColor.BackColor = Color.WhiteSmoke;
                if (cboxColor.SelectedIndex == 8)
                    panelColor.BackColor = Color.Black;
            }
        }

    }
}
