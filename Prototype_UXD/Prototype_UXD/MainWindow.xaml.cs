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

namespace Prototype_UXD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		public enum Layouts
		{
			firstPage,
			secondPage
		}

        public MainWindow()
        {
            InitializeComponent();
			firstPage.Visibility = Visibility.Visible;
			secondPage.Visibility = Visibility.Collapsed;
			thirdPage.Visibility = Visibility.Collapsed;
			fourthPage.Visibility = Visibility.Collapsed;

			KottbullarOPotatismos.FoodName = "Köttbullar och potatis";
			KottbullarOPotatismos.FoodType = "KÖTT";
			LaxOPotatis.FoodName = "Lax och potatis";
			LaxOPotatis.FoodType = "FISK";
			Sallad.FoodName = "Sallad";
			Sallad.FoodType = "VEGETARISKT";
			GlutenfrittBrod.FoodName = "Glutenfritt Bröd";
			GlutenfrittBrod.FoodType = "GLUTENFRITT";
			KycklingOCurry.FoodName = "Kyckling Och Curry";
			KycklingOCurry.FoodType = "KYCKLING";
			GottOBlandat.FoodName = "Gott Och Blandat";
			GottOBlandat.FoodType = "SNACKS";
        }

		public void changeLayout(Layouts layout)
		{
			switch (layout)
			{
				case Layouts.firstPage:

					break;
				case Layouts.secondPage:
					firstPage.Visibility = Visibility.Collapsed;
					secondPage.Visibility = Visibility.Visible;
					break;
				default:
					break;
			}
		}

		private void Select_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			secondPage.Visibility = Visibility.Collapsed;
			thirdPage.Visibility = Visibility.Visible;
		}

		private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			secondPage.Visibility = Visibility.Collapsed;
			firstPage.Visibility = Visibility.Visible;
		}

		private void Select_rect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			thirdPage.Visibility = Visibility.Collapsed;
			fourthPage.Visibility = Visibility.Visible;
		}

		private void Back_rect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			thirdPage.Visibility = Visibility.Collapsed;
			secondPage.Visibility = Visibility.Visible;
		}

		//public Brush Picture
		//{
		//	get
		//	{
		//		return FoodPicture.Fill;
		//	}
		//	set
		//	{
		//		FoodPicture.Fill = value;
		//	}
		//}
	}
}
