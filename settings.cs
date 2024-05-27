using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombParty2
{
    public partial class settings : Form
    {
        
        public settings()
        {
            InitializeComponent();
        }

        private void livesValue_ValueChanged(object sender, EventArgs e)
        {
            globals.lives = ((int)livesValue.Value);
            label1.Text = globals.lives.ToString();
        }
    }
    public static class globals
    {

        public static int lives = 3; 



    }
}
