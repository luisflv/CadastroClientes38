﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroCliente38
{
    public partial class Form1 : Form
    {

        MySqlConnection Conexao;
        //FONTE DE DADOS - HOST - USERNAME - PASSWORD - BD
        string dataSource = "datasource=localhost," +
            "username=root," +
            "password=root," +
            "database=bd_clientes";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
