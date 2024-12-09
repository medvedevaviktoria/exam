using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//содержание



namespace hangman
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void button1player_Click(object sender, EventArgs e)
        {
            this.Hide();
            oneplayer oneplayerwindow = new oneplayer();
            oneplayerwindow.Show();
            
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2players_Click(object sender, EventArgs e)
        {
            this.Hide();
            twoplayersFIRST twoplayerswindow1 = new twoplayersFIRST();
            twoplayerswindow1.Show();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rules rulesWindow = new Rules();
            rulesWindow.Show();
        }
    }
}
