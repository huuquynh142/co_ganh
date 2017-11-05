using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace co_ganh
{
    public partial class newGame : Form 
    {
        
        public newGame()
        {
            InitializeComponent();
            
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void buttonchonquan_Click(object sender, EventArgs e)
        {
            if (txtnguoi1.Text != "" && txtnguoi2.Text != "")
            {
                if (radioButtontrang.Checked)
                {
                    coghanh.luotdi = 1;
                }
                if (radioButtonđen.Checked)
                {
                    coghanh.luotdi = 2;
                }
                coghanh.tennguoi1 = txtnguoi1.Text;
                coghanh.tennguoi2 = txtnguoi2.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin ");
            }
        }


    }
  
   
}
