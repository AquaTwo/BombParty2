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
        
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game game = new game();
            game.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
