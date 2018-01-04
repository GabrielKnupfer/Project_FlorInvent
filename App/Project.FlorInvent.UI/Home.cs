using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.FlorInvent.UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            Control menu = new Control();
            this.Controls.Add(menu);
        }
    }
}
