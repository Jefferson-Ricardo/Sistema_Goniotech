using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Goniotech
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_paciente_Click(object sender, EventArgs e)
        {
            Cadastrar_Paciente cadastrar_Paciente = new Cadastrar_Paciente();
            cadastrar_Paciente.Show();
        }

        private void btn_cadastrar_fisio_Click(object sender, EventArgs e)
        {
            Cadastrar_Fisio cadastrar_Fisio = new Cadastrar_Fisio();
            cadastrar_Fisio.Show();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            Localizar_Paciente localizar_Paciente = new Localizar_Paciente();
            localizar_Paciente.Show();
        }
    }
}
