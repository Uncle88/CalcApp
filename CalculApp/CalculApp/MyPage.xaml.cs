using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CalculApp
{
	public partial class MyPage : ContentPage
	{
		 const int PERSENTEG = 17;

		public MyPage ()
		{
			InitializeComponent ();
			_button.Clicked += _button_Clicked;
		}

		void _button_Clicked (object sender, EventArgs e)
		{
			var	text = (double.Parse (_entry.Text)).ToString();

			var	_tip = (text * 17 / 100).ToString ();

			var	_totalSum = (text + _tip).ToString();
		}
	}
}

