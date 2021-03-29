using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Кот
{
    public partial class Cats : Form
    {
        public Cats()
        {
            InitializeComponent();
            CatPicture.Image = Properties.Resources.Обычный_photo_resizer_ru;
            BigCatPicture.Image = Properties.Resources.Няша1_photo_resizer_ru;
            LittleCatPicture.Image = Properties.Resources.Маленький_photo_resizer_ru;
            
        }

        private void DianaButton_CLick(object sender, EventArgs e)
        {
            DianaButton.BackColor = Color.LightGreen;

            Dianka dianka = new Dianka(); // Cоздание объекта Обычный кот Класс обычно кота
            dianka.Voice(); // Вызова метода Voice() Класса Cat 

            DianaButton.BackColor = Color.White; // Измненеие цвета кнопки
        }
        private void NormalCatButton_Click(object sender, EventArgs e) // При нажатии в форме Cats 
        { // Кнопки "Обычный кот" 
            NormalCatButton.BackColor = Color.LightGreen; // Измненеие цвета кнопки

            Tracking tracking = new Tracking(); // Создание объекта Формы Tracking 
            tracking.normalCat(); // Вызов метода Обычного кота В форме Trakcing 

            Cat cat = new Cat(); // Cоздание объекта Обычный кот Класс обычно кота
            cat.Voice(); // Вызова метода Voice() Класса Cat 

           
            NormalCatButton.BackColor = Color.White; // Измненеие цвета кнопки
        }

        private void BigCatButton_Click(object sender, EventArgs e) // При нажатии в форме Cats 
        { // Кнопки "Большой кот"
            BigCatButton.BackColor = Color.LightGreen; // Измненеие цвета кнопки

            Tracking tracking = new Tracking(); // Создание объекта Формы Tracking 
            tracking.bigCat(); // Вызов метода Большого кота В форме Trakcing 

            BigCat bigCat = new BigCat(); // Cоздание объекта Большой кот Класс большого кота
            bigCat.Voice(); // Вызова метода Voice() Класса Маленький кот

            BigCatButton.BackColor = Color.White; // Измненеие цвета кнопки
        }

        private void LittleCatButton_Click(object sender, EventArgs e) // При нажатии в форме Cats 
        { // Кнопки "Маленький кот"
            LittleCatButton.BackColor = Color.LightGreen; // Измненеие цвета кнопки

            Tracking tracking = new Tracking(); // Создание объекта Формы Tracking 
            tracking.littleCat(); // Вызов метода Маленького кота В форме Trakcing 

            LittleCat littleCat = new LittleCat(); // Cоздание объекта Маленький кот Класс маленького кота
            littleCat.Voice(); // Вызова метода Voice() Класса Маленький кот

            LittleCatButton.BackColor = Color.White; // Измненеие цвета кнопки
        }
    }
}
