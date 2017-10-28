using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio.DAO.Repositorios;
using Repositorio.Entidades;

namespace Apresentacao
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A22 a22 = new A22();
            a22.A22_001_c = textBox1.Text;
            a22.A22_002_c = textBox2.Text;
           
            a22.Timestamp = DateTime.Now;
            a22.A23 = null;
            a22.Ukey = Guid.NewGuid();

            RepositorioA22 pais = new RepositorioA22();
            pais.adicionar(a22);
            pais.SalvarTodos();
            
        }
    }
}
