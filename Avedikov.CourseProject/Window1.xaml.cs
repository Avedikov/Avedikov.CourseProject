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
	/// Логика взаимодействия для Window1.xaml
	/// </summary>
	
		public partial class Window1 : Window
		{
			private Window _mainWidnow;

			public Window1(Window mainWindow)
			{
				InitializeComponent();
				_mainWidnow = mainWindow;
			}

			protected override void OnClosed(EventArgs e)
			{
				base.OnClosed(e);
				_mainWidnow.Show();
			}

			private void Button_Click(object sender, RoutedEventArgs e)
			{
				MainWindow Drinks = new MainWindow();
				Hide();
				Drinks.ShowDialog();
			}

			private void Button_Click_1(object sender, RoutedEventArgs e)
			{
				Drinks window1 = new Drinks(this);
				Hide();
				window1.ShowDialog();
			}

			private void Button_Click_2(object sender, RoutedEventArgs e)
			{
				Meat window1 = new Meat(this);
				Hide();
				window1.ShowDialog();
			}

			private void Button_Click_3(object sender, RoutedEventArgs e)
			{
				Fish window1 = new Fish(this);
				Hide();
				window1.ShowDialog();
			}

			private void Button_Click_4(object sender, RoutedEventArgs e)
			{
				Fruits window1 = new Fruits(this);
				Hide();
				window1.ShowDialog();
			}

			private void Button_Click_5(object sender, RoutedEventArgs e)
			{
				Products window1 = new Products(this);
				Hide();
				window1.ShowDialog();
			}

			private void Button_Click_6(object sender, RoutedEventArgs e)
			{
				Drinks Window1 = new Drinks(this);
				Hide();
				Window1.ShowDialog();
			}

		}
	
}
