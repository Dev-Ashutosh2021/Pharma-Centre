using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCentre.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {

        function fn = new function();
        String query;

        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtID.Text!="" && txtMedicineName.Text!="" && txtMedicineNumber.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text!="")
            {
                String mid = txtID.Text;
                String mname = txtMedicineName.Text;
                String mnumber = txtMedicineNumber.Text;
                String mdate = txtManufacturingDate.Text;
                String edate = txtExpiryDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic(mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mdate + "','" + edate + "'," + quantity + "," + perunit + ")";
                fn.setData(query, "Medicine Added to Database.");
            }
            else
            {
                MessageBox.Show("Enter all the Data.", "Infornmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtID.Clear();
            txtMedicineName.Clear();
            txtQuantity.Clear();
            txtMedicineNumber.Clear();
            txtPricePerUnit.Clear();
            txtManufacturingDate.ResetText();
            txtExpiryDate.ResetText();
        }
    }
}
