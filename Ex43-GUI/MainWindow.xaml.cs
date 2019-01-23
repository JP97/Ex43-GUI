using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace Ex43_GUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btn_ScrollUp(object sender, RoutedEventArgs e)
		{
			

			string temp;

			temp = Fourth.Text;

			Fourth.Text = Third.Text;
			Third.Text = Second.Text;
			Second.Text = First.Text;
			First.Text = temp;
			//for (int i = 40; i < 3200; i += 500)
			//{
			//	Console.Beep(i, 750);
			//}

			//Console.Beep(523, 500);
			//Console.Beep(587, 500);
			//Console.Beep(659, 500);
			//Console.Beep(698, 500);
			//Console.Beep(784, 800);
			//Console.Beep(784, 500);
			//Console.Beep(876, 400);
			//Console.Beep(876, 400);
			//Console.Beep(876, 400);
			//Console.Beep(876, 400);
			//Console.Beep(784, 800);
			//Console.Beep(876, 400);
			//Console.Beep(876, 400);
			//Console.Beep(876, 400);
			//Console.Beep(876, 400);
			//Console.Beep(784, 800);
			//Console.Beep(698, 400);
			//Console.Beep(698, 400);
			//Console.Beep(698, 400);
			//Console.Beep(698, 400);
			//Console.Beep(659, 700);
			//Console.Beep(659, 500);
			//Console.Beep(587, 400);
			//Console.Beep(587, 400);
			//Console.Beep(587, 400);
			//Console.Beep(587, 400);
			//Console.Beep(523, 1000);



			//Console.Beep(300, 750);
			//Thread.Sleep(50);
			//Console.Beep(300, 750);
			//Thread.Sleep(50);
			//Console.Beep(300, 750);
			//Thread.Sleep(50);
			//Console.Beep(250, 750);
			//Thread.Sleep(50);
			//Console.Beep(350, 250);
			//Console.Beep(300, 500);
			//Thread.Sleep(50);
			//Console.Beep(250, 500);
			//Thread.Sleep(50);
			//Console.Beep(350, 250);
			//Console.Beep(300, 500);
			//Thread.Sleep(50);

		}

		private void btn_Clear(object sender, RoutedEventArgs e)
		{
			First.Text = "TextBox1";
			Second.Text = "TextBox2";
			Third.Text = "TextBox3";
			Fourth.Text = "TextBox4";
		
		}

		private void btn_ScrollDown(object sender, RoutedEventArgs e)
		{
			string temp;

			temp = First.Text;

			First.Text = Second.Text;
			Second.Text = Third.Text;
			Third.Text = Fourth.Text;
			Fourth.Text = temp;
			Console.Beep(22000, 1);
		}

		private void btn_HiddenFeature(object sender, RoutedEventArgs e)
		{
			First.Text = "Julian er cool";
			Second.Text = "Julian er den bedste";
			Third.Text = "Julian er the most awesome guy";
			Fourth.Text = "julian is de brain!!!";

			//for (int i = 0; i < 10; i++)
			//{
			//	System.Threading.Thread.Sleep(1000);
			//	btn_ScrollUp2();
			//}
		}

		public void btn_ScrollUp2()
		{
			string temp;

			temp = First.Text;

			First.Text = Second.Text;
			Second.Text = Third.Text;
			Third.Text = Fourth.Text;
			Fourth.Text = temp;
		}
	}
}
