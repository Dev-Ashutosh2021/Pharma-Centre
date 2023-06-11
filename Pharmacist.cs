﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCentre
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible=false;
            uC_P_AddMedicine1.Visible=false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible=false;
            uC_P_SellMedicine1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicine1.Visible = true;
            uC_P_ViewMedicine1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMedicine1.Visible = true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront() ;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible=true;
            uC_P_SellMedicine1.BringToFront();
        }
    }
}
