﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testApp
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
        }

        private void SignForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter.Fill(this.databaseDataSet.Documents);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
