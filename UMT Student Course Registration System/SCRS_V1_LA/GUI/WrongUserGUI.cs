using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect25_W3_LA.GUI
{
    public partial class WrongUserGUI : Form
    {
        public WrongUserGUI()
        {
            InitializeComponent();
        }

        private void WrongUserGUI_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
        }
    }
}
