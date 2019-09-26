using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Process
    {
        public void Save(Directory directory, DataGridView dataGridView)
        {
            DataGridViewRow rows = new DataGridViewRow();
            rows.CreateCells(dataGridView);
            rows.Cells[0].Value = directory.Name;
            rows.Cells[1].Value = directory.Lastname;
            rows.Cells[2].Value = directory.Age;
            rows.Cells[3].Value = directory.DateBirth;
            rows.Cells[4].Value = directory.Address;
            rows.Cells[5].Value = directory.Province;
            rows.Cells[6].Value = directory.Country;
            rows.Cells[7].Value = directory.Phone;
            rows.Cells[8].Value = directory.Mobile;
            dataGridView.Rows.Add(rows);

        }

        public void Delete(DataGridView dataGridView)
        {
            dataGridView.Rows.Remove(dataGridView.CurrentRow);

        }
    }
}
