﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAutorization.users.type == "agent") buttonOpenAgents.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAutorization.users.login;
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }
        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formAgents = new FormAgents();
            formAgents.Show();
        }

        private void buttonOpenSupplySet_Click (object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            Form formDemand = new FormDemand();
            formDemand.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            Form formDeal = new FormDeal();
            formDeal.Show();
        }
    }
}
