using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private Directory directory;
        private Process process = new Process();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" &&
                txtLastName.Text.Trim() != "" &&
                txtAge.Text.Trim() != "" &&
                mtxtDateBirth.Text.Trim() != "" &&
                txtAddress.Text.Trim() != "" &&
                txtProvince.Text.Trim() != "" &&
                txtCountry.Text.Trim() != "" &&
                mtxtPhone.Text.Trim() != "" &&
                mtxtMobile.Text.Trim() != ""
                )
            {
                try
                {
                    string name = txtName.Text;
                    string lastname = txtLastName.Text;
                    short age = Convert.ToInt16(txtAge.Text);
                    string dateBirth = mtxtDateBirth.Text;
                    string address = txtAddress.Text;
                    string province = txtProvince.Text;
                    string country = txtCountry.Text;
                    string phone = mtxtPhone.Text;
                    string mobile = mtxtMobile.Text;

                    directory = new Directory(name, lastname, age, dateBirth, address, province, country, phone, mobile);

                    process.Save(directory,  dataGridView1);

                    txtName.Clear();
                    txtLastName.Clear();
                    txtAge.Clear();
                    mtxtDateBirth.Clear();
                    txtAddress.Clear();
                    txtProvince.Clear();
                    txtCountry.Clear();
                    mtxtPhone.Clear();
                    mtxtMobile.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Rellena todos los campos");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show(this, "¿Seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    process.Delete(dataGridView1);
                }
            }
        }
    }
}
