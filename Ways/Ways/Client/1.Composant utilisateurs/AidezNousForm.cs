﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_utilisateur_de_communication;

namespace Ways.Client._1.Composant_utilisateurs
{
    public partial class AidezNousForm : Form
    {
        public Reponse reponse;

        public AidezNousForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reponse = new Reponse("Aidez Nous", 2);

            this.Hide();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.reponse = new Reponse("Pas de réponse", 0);
        }
    }
}