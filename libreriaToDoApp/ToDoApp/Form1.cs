using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaToDoApp.Modelo;
using libreriaToDoApp; 

namespace ToDoApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //estoy haciendo un cambio... 
                string CMD = string.Format("select * from usuarios where username ='"+this.texNombre.Text+"'");
                DataSet ds = Sql.Ejecutar(CMD);
                String user = ds.Tables[0].Rows[0]["username"].ToString().Trim();
                String contraseña = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                int Idusuario = int.Parse(ds.Tables[0].Rows[0]["Id_usuario"].ToString().Trim());
                String clave = this.texContraseña.Text;
                String usuario = this.texNombre.Text;
                if (user == usuario && contraseña == clave)
                {
                    Principal p = new Principal(Idusuario); ;
                   this.Visible = false;
                    p.Show();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Usuario o contraseña incorrecta...");
                String error = ""+exc; 
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperacion_de_Contraseña recuperacion_De_Contraseña = new Recuperacion_de_Contraseña();
            recuperacion_De_Contraseña.ShowDialog();
            if (recuperacion_De_Contraseña.DialogResult == DialogResult.Yes)
            {
                //aqui //ok
            }
        }
    }
}
