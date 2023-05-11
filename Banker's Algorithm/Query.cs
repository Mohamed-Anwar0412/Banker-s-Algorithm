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
    public partial class Query : Form
    {
        private int numProc, numRes;
        private DataGridView cuAll, av, Max;
        private int[,] remain;
        private List<int> safeSeq;
        public Query(int numProc, int numRes, DataGridView cuAll, DataGridView av, DataGridView Max)
        {
            InitializeComponent();
            this.numProc = numProc;
            this.numRes = numRes;
            this.cuAll = cuAll;
            this.av = av;
            this.Max = Max;
            this.remain = new int[numProc, numRes];
            this.safeSeq = new List<int>();
            setup();
        }

        private void setup()
        {
            for (int i = 0; i < numProc; i++)
                comboBox1.Items.Add(i + 1);
            for (int i = 0; i < numRes; i++)
                comboBox2.Items.Add(i + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool[] safe = new bool[numProc];
            int proc = comboBox1.SelectedIndex;
            int res = comboBox2.SelectedIndex;
            int val = int.Parse(cuAll.Rows[proc].Cells[res].Value.ToString());
            cuAll.Rows[proc].Cells[res].Value = val + int.Parse(textBox1.Text);
            Console.WriteLine(cuAll.Rows[proc].Cells[res].Value);

            for (int i = 0; i < numProc; i++)
            {
                for (int j = 0; j < numRes; j++)
                {
                    remain[i, j] = int.Parse(Max.Rows[i].Cells[j].Value.ToString()) - int.Parse(cuAll.Rows[i].Cells[j].Value.ToString());
                }
            }
            val = int.Parse(av.Rows[proc].Cells[res].Value.ToString());
            av.Rows[proc].Cells[res].Value = val - int.Parse(textBox1.Text);

            for (int i = 0; i < numProc; i++)
            {
                safe[i] = check(i);
            }
            for (int k = 0; k < numProc - 1; k++)
            {
                if (!Done(safe))
                {
                    for (int i = 0; i < safe.Length; i++)
                    {
                        if (!safe[i])
                        { safe[i] = check(i); }
                    }
                }
                else { break; }
            }
            result re = new result(safe, safeSeq);
            this.Hide();
            re.ShowDialog();
            this.Close();


        }

        private bool Done(bool[] arr)
        {
            foreach (var item in arr)
            {
                if (!item)
                    return false;
            }
            return true;
        }

        private bool check(int proc)
        {
            for (int i = 0; i < numRes; i++)
            {
                if (remain[proc, i] > int.Parse(av.Rows[0].Cells[i].Value.ToString()))
                {
                    return false;
                }
            }
            int val;
            for (int i = 0; i < numRes; i++)
            {
                val = int.Parse(av.Rows[0].Cells[i].Value.ToString());
                av.Rows[0].Cells[i].Value = val + int.Parse(cuAll.Rows[proc].Cells[i].Value.ToString());
            }
            safeSeq.Add(proc);
            return true;
        }

        private void text_box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
    }
}
