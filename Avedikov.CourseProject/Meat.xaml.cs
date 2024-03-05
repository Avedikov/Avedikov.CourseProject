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
using System.Windows.Shapes;

namespace Avedikov.CourseProject
{
	/// <summary>
	/// Логика взаимодействия для Meat.xaml
	/// </summary>
	public partial class Meat : Window
	{
		private Window _mainwindow;

		public Meat(Window mainwindow)
		{
			InitializeComponent();
			_mainwindow = mainwindow;
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			_mainwindow.Show();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Drinks Meat = new Drinks(this);
			Hide();
			Meat.ShowDialog();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MainWindow Drinks = new MainWindow();
			Hide();
			Drinks.ShowDialog();
		}
	}
}
