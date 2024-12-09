using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;
using hangman.Properties;

namespace hangman
{
    public partial class oneplayer : Form
    {
        
        public oneplayer()
        {
            InitializeComponent();
        }


        //кнопка В меню
        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu menuwidnow = new mainmenu();
            menuwidnow.Show();
        }



        //кнопка выбора категории
        private void choosecategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            hiddenword_label.Text = "";
            DateBank.ChoosenCategory = choosecategory.Text; // вписываем категорию которую выбрал пользователь
            Random rand = new Random();



            //рандомный выбор слова в каждой из категорий
        category:
            switch (DateBank.ChoosenCategory)
            {
                case "Фрукты и ягоды":
                    DateBank.Index = rand.Next(words.fruits.Length); //присваиваем индексу номер случайного слова из категории
                    DateBank.HiddenWord = words.fruits[DateBank.Index]; // загаданное слово = слово по номеру из массива
                    break;

                case "Страны":
                    DateBank.Index = rand.Next(words.countries.Length);
                    DateBank.HiddenWord = words.countries[DateBank.Index];
                    break;
                case "Спорт":
                    DateBank.Index = rand.Next(words.sport.Length);
                    DateBank.HiddenWord = words.sport[DateBank.Index];
                    break;
                case "Профессии":
                    DateBank.Index = rand.Next(words.jobs.Length);
                    DateBank.HiddenWord = words.jobs[DateBank.Index];
                    break;
                case "Музыкальные инструменты":
                    DateBank.Index = rand.Next(words.musicalinstruments.Length);
                    DateBank.HiddenWord = words.musicalinstruments[DateBank.Index];
                    break;
                case "Случайная категория":
                    DateBank.Index = rand.Next(words.categories.Length);
                    DateBank.ChoosenCategory = words.categories[DateBank.Index];
                    goto category;
            }


            Console.WriteLine(DateBank.HiddenWord);

            DateBank.HiddenWordLettersCount = DateBank.HiddenWord.Length;// количество букв в загаданном слове




            //в первый раз в hiddenword_label записываем слово используя андерскоры

            for (DateBank.Index = 0; DateBank.Index < DateBank.HiddenWordLettersCount; DateBank.Index++)
            {
                DateBank.HiddenWordLettersArray[DateBank.Index] = '_';
                hiddenword_label.Text = hiddenword_label.Text + "   " + DateBank.HiddenWordLettersArray[DateBank.Index];
            }

            for (DateBank.Index = 0; DateBank.Index < DateBank.HiddenWordLettersCount; DateBank.Index++)
            {
                DateBank.HiddenWordLettersShowArray[DateBank.Index] = DateBank.HiddenWord[DateBank.Index];
            }

            //кнопка старт становится доступной
            buttonStart.Enabled = true;

        }



        //кнопка запуска игры
        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelcategory.Text = "Категория:  " + DateBank.ChoosenCategory;
            choosecategory.Visible = false;
            choosecategory.Enabled = false;
            labelEnter.Visible = true;
            userGuessLetter.Visible = true;
            buttonGuess.Visible = true;
            buttonStart.Visible = false;
            pictureBox1.Visible = true;
            hiddenword_label.Visible = true;





        }


        //кнопка угадвания не работает пока поле с буквой не заполнено
        private void userGuessLetter_TextChanged(object sender, EventArgs e)
        {
            if (userGuessLetter.Text.Length == 0) buttonGuess.Enabled = false;
            else buttonGuess.Enabled = true;

        }


        //пользователь может писать только русские строчные буквы и бэкспейс
        private void userGuessLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || c == 'ё' || c == 8 );
        }



        //при нажатии кнопки угадывания буквы
        private void buttonGuess_Click(object sender, EventArgs e)
        {
            DateBank.ErrorLetterCheck = 0;
            hiddenword_label.Text = "";


            DateBank.GuessLetter = userGuessLetter.Text.ToCharArray()[0];


            //int errorLetterCheck = 0;
            //сравниваем букву введённую пользователем 
            //принцип такой: если буква введённая пользователем равна той же букве в загаданном слове, то errorLetterCheck инкрементируется,
            //далее проверяется условие равна ли эта переменная 0. 
            //да = значит мы ошиблись с буквой errorLetter инкрементируется как счётчик ошибок
            //нет = значит мы не ошиблись с буквой errorLetter не инкрементируется
            for (DateBank.Index = 0; DateBank.Index < DateBank.HiddenWordLettersCount; DateBank.Index++)
            {
                if (DateBank.GuessLetter == DateBank.HiddenWordLettersShowArray[DateBank.Index])
                {
                    DateBank.HiddenWordLettersArray[DateBank.Index] = DateBank.HiddenWordLettersShowArray[DateBank.Index];
                    DateBank.ErrorLetterCheck++;
                }
            }
            if (DateBank.ErrorLetterCheck == 0)
                DateBank.ErrorLetter++;
                
            //проверка колва ошибок для изображения

            switch (DateBank.ErrorLetter)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("D:\\college\\hangman\\pictures\\Img1.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("D:\\college\\hangman\\pictures\\Img2.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("D:\\college\\hangman\\pictures\\Img3.png"); 
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("D:\\college\\hangman\\pictures\\Img4.png");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("D:\\college\\hangman\\pictures\\Img5.png");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("D:\\college\\hangman\\pictures\\Img6.png"); 
                    break;

            }


            //слово показывается пользователю после всех проверок со всеми отгаданными и неотгаданными буквами
            for (DateBank.Index = 0; DateBank.Index < DateBank.HiddenWordLettersCount; DateBank.Index++)
            {
                hiddenword_label.Text = hiddenword_label.Text + "   " + DateBank.HiddenWordLettersArray[DateBank.Index];
            }
            userGuessLetter.Text = String.Empty;

            DateBank.RightLetter = 0;
            for (DateBank.Index = 0; DateBank.Index < DateBank.HiddenWordLettersCount; DateBank.Index++)
            {
                if (DateBank.HiddenWordLettersArray[DateBank.Index] != '_')
                {
                    DateBank.RightLetter++;
                }

            }

            //сообщения о проигрыше либо выигрыше
            if (DateBank.RightLetter == DateBank.HiddenWordLettersCount)
            {
                this.Close();
                win1p win1pWindow = new win1p();
                win1pWindow.Show();
            }

            if (DateBank.ErrorLetter == 6)
            {
                this.Close();
                lose1p lose1pWindow = new lose1p();
                lose1pWindow.Show();
            }
        }

        private void oneplayer_Load(object sender, EventArgs e)
        {
            DateBank.ErrorLetter = 0;//сколько раз пользователь угадал букву

        }
    }
    
}