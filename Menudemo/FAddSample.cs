using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menudemo
{
    public partial class FAddSample : Form
    {
        public FAddSample()
        {
            InitializeComponent();
        }

        public virtual void btn_Save_Click(object sender, EventArgs e)
        {

        }

        public virtual void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
