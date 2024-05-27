using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombParty2
{
    public partial class main : Form
    {
        game game = new game();

        public main()
        {
            InitializeComponent();

            if (globals.lives == -1)
            {
                game.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Show();

        }
    }
}
