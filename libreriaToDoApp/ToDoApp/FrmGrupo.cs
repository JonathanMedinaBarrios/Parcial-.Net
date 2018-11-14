﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaToDoApp.Modelo;

namespace ToDoApp
{
    public partial class FrmGrupo : Form
    {
        public FrmGrupo(string padre)
        {
            InitializeComponent();
            grupoPadre.Text = padre;
        }

        public FrmGrupo() {
            InitializeComponent();

        }

        public Grupo GetGrupo()
        {
            return new Grupo() { Nombre = this.textBox1.Text };
        }
    }
}
