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
    public partial class win2p : Form
    {
        public win2p()
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

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonchange_Click(object sender, EventArgs e)
        {
            this.Close();
            twoplayersSECOND twoplayersWindow2 = new twoplayersSECOND();
            twoplayersWindow2.Close();
            mainmenu menuwidnow = new mainmenu();
            menuwidnow.Show();
        }

        private void win2p_Load(object sender, EventArgs e)
        {
            label2.Text = "Поздравляю, Вы угадали!\r\nЗагаданным словом было <" + DateBank.HiddenWord + ">.\r\nПопробуете ещё разок? :)";

        }
    }
}
