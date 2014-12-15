using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Prototype_UXD
{
	/// <summary>
	/// Interaction logic for FoodButton.xaml
	/// </summary>
	public partial class FoodButton : UserControl
	{
		private MainWindow mainWindow;

		public FoodButton()
		{
			this.InitializeComponent(); 
		}
		private void Confirm_Loaded(object sender, RoutedEventArgs e)
		{
			mainWindow = Application.Current.MainWindow as MainWindow;
		}


		public Brush Picture
		{
			get
			{
				return FoodPicture.Fill;
			}
			set
			{
				FoodPicture.Fill = value;
			}
		}

		public String FoodName { get; set; }

		private void Select_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			mainWindow.changeLayout(MainWindow.Layouts.secondPage);
			mainWindow.FoodPicture.Fill = FoodPicture.Fill;
			mainWindow.FoodName_txb.Text = FoodName;
		}
	}
}