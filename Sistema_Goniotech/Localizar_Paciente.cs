﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;


namespace Sistema_Goniotech
{
    public partial class Localizar_Paciente : Form
    {
        public Localizar_Paciente()
        {
            InitializeComponent();
        }

        private void btn_avaliar_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            //sensor.show
        }
    }
}
