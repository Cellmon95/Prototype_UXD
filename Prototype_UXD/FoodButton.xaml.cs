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

		public String FoodName 
		{
			get
			{
				return FoodName_txtb.Text;
			}

			set
			{
				FoodName_txtb.Text = value;
			}
		}
		public String FoodType
		{
			get
			{
				return LabelText_txtb.Text;
			}
			set
			{
				BrushConverter bc = new BrushConverter();
				switch (value)
				{
					case "KÖTT":
						LabelText_txtb.Text = value;
						BackgroundLabel_rect.Fill = (Brush)bc.ConvertFrom("Red");
						break;
					case "FISK":
						LabelText_txtb.Text = value;
						BackgroundLabel_rect.Fill = (Brush)bc.ConvertFrom("Blue");
						break;
					case "VEGETARISKT":
						LabelText_txtb.Text = value;
						BackgroundLabel_rect.Fill = (Brush)bc.ConvertFrom("Green");
						break;
					case "GLUTENFRITT":
						LabelText_txtb.Text = value;
						BackgroundLabel_rect.Fill = (Brush)bc.ConvertFrom("Yellow");
						break;
					case "KYCKLING":
						LabelText_txtb.Text = value;
						BackgroundLabel_rect.Fill = (Brush)bc.ConvertFrom("Purple");
						break;
					case "SNACKS":
						LabelText_txtb.Text = value;
						BackgroundLabel_rect.Fill = (Brush)bc.ConvertFrom("#555555");
						IsSnacks = true;
						break;
					default:
						throw new Exception();
						//break;
				}
			}
		}

		public bool IsSnacks { get; set; }

		private void Select_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (IsSnacks)
			{
				mainWindow.changeLayout(MainWindow.Layouts.snacksPage);
			}
			else
			{
				mainWindow.changeLayout(MainWindow.Layouts.secondPage);
				mainWindow.FoodPicture.Fill = FoodPicture.Fill;
				mainWindow.FoodName_txb.Text = FoodName;
			}
		}
	}
}