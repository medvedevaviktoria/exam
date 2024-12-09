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
    public partial class twoplayersFIRST : Form
    {

        twoplayersSECOND tps;

        public twoplayersFIRST()
        {

            InitializeComponent();
        }





        //кнопка В меню
        private void buttonback1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu menuwidnow = new mainmenu();
            menuwidnow.Show();
        }


        //кнопка старта не нажмется пока пустое одно из двух текстбоксов
        private void textBoxtCategory_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxtCategory.Text.Length == 0) || (textBoxWord.Text.Length == 0)) buttonStart.Enabled = false;
            else buttonStart.Enabled = true;
        }


        //кнопка старта не нажмется пока пустое одно из двух текстбоксов
        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxtCategory.Text.Length == 0) || (textBoxWord.Text.Length == 0)) buttonStart.Enabled = false;
            else buttonStart.Enabled = true;
        }



        //пользователь может ввести только русские буквы и бэкспейс
        private void textBoxtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || c == 'ё' || c == 8);
        }

        //пользователь может ввести только русские буквы и бэкспейс
        private void textBoxWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || c == 'ё' || c == 8);
        }




        //нажата кнопка начала игры
        private void buttonStart_Click(object sender, EventArgs e)
        {

            
            DateBank.ChoosenCategory = textBoxtCategory.Text;//передаем категорию от первого игрока второму игроку
            DateBank.HiddenWord = textBoxWord.Text;//передаем слово от первого игрока второму игроку


            DateBank.HiddenWordLettersCount = DateBank.HiddenWord.Length;// количество букв в загаданном слове


            //открываем вторую форму = переходим к форме twoplayersSECOND
            tps = new twoplayersSECOND();
            tps.Show();
            this.Close();


        }

    }



    
}
