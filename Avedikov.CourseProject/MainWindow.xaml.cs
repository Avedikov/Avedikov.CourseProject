using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Avedikov.CourseProject;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Window1 window1 = new Window1(this);
			Hide();
			window1.ShowDialog();
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

	
}