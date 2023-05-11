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
    public partial class result : Form
    {
        bool[] safe;
        List<int> safeSeq;
        public result(bool[] safe, List<int> safeSeq)
        {
            InitializeComponent();
            this.safe = safe;
            this.safeSeq = safeSeq;
            showResults();
        }

        public void showResults()
        {
            bool unsaf = false;
            foreach (var proc in safe)
            {
                if (!proc)
                {
                    unsaf = true;
                    break;
                }
            }
            if (unsaf)
            {
                label1.Text = "Unsafe for this request!!";
            }
            else
            {
                string s = "Safe with Sequence:";

                for (int i = 0; i < safeSeq.Count; i++)
                {
                    s += " P" + (safeSeq[i] + 1);
                }
                label1.Text = s;
            }
        }
    }
}
