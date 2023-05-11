using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banker_s_Algorithm
{
    public partial class Data : Form
    {
        private int numProc, numRes;
        public Data(int numProc, int numRes)
        {
            InitializeComponent();
            this.numProc = numProc;
            this.numRes = numRes;
            button2.Hide();
            setTables();
        }

        private void setTables()
        {
            string name;
            for (int i = 0; i < numRes; i++)
            {
                name = "R" + (i + 1);
                currentAllocation.Columns.Add(name, name);
                totalView.Columns.Add(name, name);
                maxNeed.Columns.Add(name, name);
                available.Columns.Add(name, name);
            }
            for (int i = 0; i < numProc; i++)
            {
                name = "P" + (i + 1);
                currentAllocation.Rows.Add();
                currentAllocation.Rows[i].HeaderCell.Value = name;
                maxNeed.Rows.Add();
                maxNeed.Rows[i].HeaderCell.Value = name;
            }
            totalView.Rows.Add();
            available.Rows.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < numRes; i++)
                {
                    int used = 0;
                    for (int j = 0; j < numProc; j++)
                    {
                        try 
                        {
                            used += int.Parse(currentAllocation.Rows[j].Cells[i].Value.ToString());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Wrong Input!!");
                        }
                    }
                    available.Rows[0].Cells[i].Value = int.Parse(totalView.Rows[0].Cells[i].Value.ToString()) - used;
                }
                button2.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query query = new Query(numProc, numRes, currentAllocation, available, maxNeed);
            this.Hide();
            query.ShowDialog();
            this.Close();
        }
    }
}
