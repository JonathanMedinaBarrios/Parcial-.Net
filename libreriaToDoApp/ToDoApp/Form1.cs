using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                string CMD = string.Format("select username, password from usuarios where username ='jonathan'");
                DataSet ds = Sql.Ejecutar(CMD);
                String user = ds.Tables[0].Rows[0]["username"].ToString().Trim();
                String contraseña = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                String clave = this.texContraseña.Text;
                if (user == "jonathan" && contraseña == clave)
                {
                    Principal p = new Principal();
                    this.Visible = false;
                    p.Show();

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
