using L_BE;
using L_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_IngSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bll_Usuario = new BLL_USUARIO();
        }
        BLL_USUARIO Bll_Usuario;

        private void button_Agregar_Click(object sender, EventArgs e)
        {
        }
    }
}
