﻿using System;
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
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            if(textBox_Nombre.Text == string.Empty || textBox_Contraseña.Text == string.Empty)
            {
                MessageBox.Show("Corrobore los campos");
                return;
            }

        }
    }
}
