using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Кот
{
    public partial class Tracking : Form
    {
        int Changer = 0; // Отслеживание количества нажатий "назад" "вперед" 

        public Tracking()
        {
            InitializeComponent();
            ArrowDown.Image = Properties.Resources.Стрелочка_вниз_photo_resizer_ru__1_;
            HomeIcon.Image = Properties.Resources.Выход_photo_resizer_ru__1_;
            ForwardIcon.Image = Properties.Resources.arrow_sign_up_down_back_photo_resizer_ru__1_;
        }

        public void Dianka()
        {
            Text = "Обычная Диана";
        }
        public void normalCat() // Метод вызыванный из формы Cats Относится к обычному коту
        {
           
            Text = "Обычный кот"; // Измненеие названия окна
            label1.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
            label1.Text = "Cat cat = new Cat(); // Создается объект cat - класса Cat ";
            Changer = 0; // Изначальное количество нажатий на кнопку "Продолжить" - 0
            ShowDialog(); // Вызов формы (окна)
        } 

        public void littleCat() // Метод вызыванный из формы Cats Относится к маленькому котенку
        {
           
            Text = "Маленький кот"; // Измненеие названия окна
            label1.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
            label1.Text = "LittleCat littleCat = new LittleCat(); // Создается LittleCat - класса LittleCat:Cat";
            Changer = 0; // Изначальное количество нажатий на кнопку "Продолжить" - 0
            ShowDialog(); // Вызов формы (окна)         
        }

        public void bigCat()  // Метод вызыванный из формы Cats Относится к большому котенку
        {
            
            Text = "Большой котише"; // Измненеие названия окна
            label1.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
            label1.Text = "BigCat bigCat = new BigCat(); // Создается объект BigCat - класса BigCat:Cat";
            Changer = 0; // Изначальное количество нажатий на кнопку "Продолжить" - 0
            ShowDialog(); // Вызов формы (окна)
        }



        private void ForwardIcon_Click(object sender, EventArgs e) // Событие клика мышки на иконку "вперед"
        {
           
            if (Text == "Обычный кот") // Если обрабатывается обычный кот
            {
                switch (Changer) // Проверка количества нажатий на кнопку "Вперед"
                {
                    case 0:
                        label1.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                        ArrowDown.Visible = true; // Измненеие видимости стрелки
                        label2.Text = "cat.Voice(); // В классе Cat вызывается метод Voice()";
                        label2.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                        label2.Visible = true; // Изменение видимости лейбла
                        Changer++; // Измненеие количества нажатий кнопки "Далее"
                        break;
                    case 1:
                        label2.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                        ArrowDown.Location = new Point(225, 97); // Измненение положения стрелки
                        label2.Location = new Point(12, 60);  // Измненеие положения лейбла 
                        label3.Text = "public virtual void Voice(); // Метод Voice() является родительским ";
                        label3.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                        label3.Visible = true; // Изменение видимости лейбла
                        Changer++; // Измненеие количества нажатий кнопки "Далее"
                        break;
                    case 2:
                        label3.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                        ArrowDown.Location = new Point(225, 140); // Измненение положения стрелки
                        label3.Location = new Point(12, 100);  // Измненеие положения лейбла 
                        label4.Text = "MessageBox.Show(\"Мяу - мяу - мяу\");  // В методе вызывается сообщение с мяуканьем";
                        label4.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                        label4.Visible = true; // Изменение видимости лейбла
                        Changer++; // Измненеие количества нажатий кнопки "Далее"
                        break;
                    case 3:
                        ArrowDown.Visible = false; // Измненеие видимости стрелки
                        label4.Location = new Point(12, 140);  // Измненеие положения лейбла 
                        label4.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                        Changer++; // Измненеие количества нажатий кнопки "Далее"
                        break;
                    case 4:
                        Close();
                        break;
                }
            }
            else // Иначе смотрим два других кота
            {
                if (Text == "Большой котише") // Если обрабатывается "большой кот"
                {
                    switch (Changer) // Проверка количества нажатий на кнопку "Вперед"
                    {
                        case 0:
                            label1.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                            ArrowDown.Visible = true; // Измненеие видимости стрелки
                            label2.Text = "bigCat.Voice(); // В классе BigCat вызывается метод Voice()";
                            label2.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                            label2.Visible = true; // Изменение видимости лейбла
                            Changer++; // Измненеие количества нажатий кнопки "Далее"

                            break;
                        case 1:
                            label2.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                            ArrowDown.Location = new Point(225, 97);  // Измненение положения стрелки
                            label2.Location = new Point(12, 60);  // Измненеие положения лейбла 
                            label3.Text = "public override void Voice(); // Метод Voice() Является наследуемым из класса Cat ";
                            label3.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                            label3.Visible = true; // Изменение видимости лейбла
                            Changer++; // Измненеие количества нажатий кнопки "Далее"
                            break;
                        case 2:
                            label3.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                            ArrowDown.Location = new Point(225, 140); // Измненение положения стрелки
                            label3.Location = new Point(12, 100);  // Измненеие положения лейбла 
                            label4.Text = "MessageBox.Show(\" * Я просто лежу на диване и не мяукаю * \");  // В методе вызывается сообщение с мяуканьем";
                            label4.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                            label4.Visible = true; // Изменение видимости лейбла
                            Changer++; // Измненеие количества нажатий кнопки "Далее"
                            break;
                        case 3:
                            ArrowDown.Visible = false; // Измненеие видимости стрелки
                            label4.Location = new Point(12, 140);  // Измненеие положения лейбла 
                            label4.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                            Changer++; // Измненеие количества нажатий кнопки "Далее"
                            break;
                        case 4:
                            Close();
                            break;
                    }
                }
                else // Если маленький кот
                {
                    switch (Changer) // Проверка количества нажатий на кнопку "Вперед"
                    {
                        case 0:
                            label1.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                            ArrowDown.Visible = true; // Измненеие видимости стрелки
                            label2.Text = "littleCat.Voice(); // В классе LittleCat вызывается метод Voice()";
                            label2.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                            label2.Visible = true; // Изменение видимости лейбла
                            Changer++; // Измненеие количества нажатий кнопки "Далее"

                            break;
                        case 1:
                            label2.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                            ArrowDown.Location = new Point(225, 97); // Измненение положения стрелки
                            label2.Location = new Point(12, 60);  // Измненеие положения лейбла 
                            label3.Text = "public override void Voice(); // Метод Voice() Является наследуемым из класса Cat";
                            label3.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                            label3.Visible = true;  // Изменение видимости лейбла
                            Changer++; // Измненеие количества нажатий кнопки "Далее"
                            break;
                        case 2:
                            label3.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                            ArrowDown.Location = new Point(225, 140); // Измненение положения стрелки
                            label3.Location = new Point(12, 100);  // Измненеие положения лейбла 
                            label4.Text = "MessageBox.Show(\"Миу - миу - миу\");  // В методе вызывается сообщение с мяуканьем";
                            label4.BackColor = Color.LightGreen; // Измненеие цвета фона Лейбла 
                            label4.Visible = true;  // Изменение видимости лейбла
                            Changer++; // Измненеие количества нажатий кнопки "Далее"
                            break;
                        case 3:
                            ArrowDown.Visible = false; // Измненеие видимости стрелки
                            label4.Location = new Point(12, 140); // Измненеие положения лейбла 
                            label4.BackColor = Color.White; // Измненеие цвета фона Лейбла 
                            Changer++; // Измненеие количества нажатий кнопки "Далее"
                            break;
                        case 4:
                            Close();     
                            break;
                    }
                }
            }
        }

        #region
        private void HomeIcon_Click(object sender, EventArgs e) // Событие клика мышки на иконку "Дом"
        {
            Close(); // Закрыть окно Tracking 
        }
        private void MouseEnter_Forward(object sender, EventArgs e) // При наведении мыши на "впред"
        {
            ForwardLabel.Visible = true; // Включить видимость лейбла
        }

        private void MouseLeave_Forward(object sender, EventArgs e) // Если убрать мышь с иконки "вперед"
        {
            ForwardLabel.Visible = false; // Выключить видимость лейбла
        }

  
        private void MouseEnter_Home(object sender, EventArgs e) // При наведении мыши на "Домой"
        {
            HomeLabel.Visible = true; // Включить видимость лейбла
        }

        private void MouseLeave_Home(object sender, EventArgs e) // Если убрать мышь с иконки "Домой"
        {
            HomeLabel.Visible = false; // Выключить видимость лейбла
        }
        #endregion
    }
}
