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
			var score = (Convert.ToDouble(_entry.Text));

			var tip = (score * PERSENTEG / 100);

			_tip.Text =tip .ToString();

			_totalSum.Text = (score + tip).ToString();

		}
	}
}

