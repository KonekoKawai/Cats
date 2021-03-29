using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кот
{
	public class LittleCat : Cat // Класс "Mаленький котенок" 
	{
		public override void Voice() // Голос маленького котенка
		{
			MessageBox.Show("Миу-миу-миу");
		}

		public void ParentsVoice() // Голос родительского класса 
		{
			base.Voice();
		}
	}

	public class BigCat : Cat  // Класс "Большой котище"
	{
		public override void Voice()
		{
			MessageBox.Show("*Я просто лежу на диване и не мяукаю*");
			
		}

		public void ParentsVoice() // Голос родительского класса 
		{
			base.Voice();
		}
	}
	public class Cat // Родительский класс "Кот"
	{
		string Имя;
		string Цвет;
		decimal Вес;
		public virtual void Voice() // Метод "Голос"
		{
			MessageBox.Show("Мяу-мяу-мяу");
		}
	}

	static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cats()); // Вызов формы Cats

		}
    }
}
