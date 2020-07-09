﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(lastNameText.Text);
        }
    }
}
