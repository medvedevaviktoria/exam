using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class lose2p : Form
    {
        public lose2p()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            twoplayersFIRST twoplayersWindow1 = new twoplayersFIRST();
            twoplayersSECOND twoplayersWindow2 = new twoplayersSECOND();
            twoplayersWindow2.Close();
            this.Hide();
            twoplayersWindow1.Show();
        }

        private void buttonchange_Click(object sender, EventArgs e)
        {
            this.Close();
            twoplayersSECOND twoplayersWindow2 = new twoplayersSECOND();
            twoplayersWindow2.Close();
            mainmenu menuwidnow = new mainmenu();
            menuwidnow.Show();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lose2p_Load(object sender, EventArgs e)
        {
            label2.Text = "К сожалению, Вы не угадали!\r\nЗагаданным словом было <" + DateBank.HiddenWord + ">.\r\nПопробуете ещё разок? :)";



        }
    }
}
