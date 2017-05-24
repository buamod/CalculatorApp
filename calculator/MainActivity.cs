
//namespace calculator
using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace calculator
{
	[Activity(Label = "calculator", MainLauncher = true, Icon = "@drawable/calc")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			double Sum = 0;
			TextView view = FindViewById<TextView>(Resource.Id.textView1);
			Button add = FindViewById<Button>(Resource.Id.add);
			Button subtract = FindViewById<Button>(Resource.Id.subtract);
			Button devide = FindViewById<Button>(Resource.Id.devide);
			Button multiply = FindViewById<Button>(Resource.Id.multiply);
			EditText text1 = FindViewById<EditText>(Resource.Id.editText1);
			EditText text2 = FindViewById<EditText>(Resource.Id.editText2);


			add.Click +=
			delegate
			{

				try
				{
					double x = 0;
					double y = 0;
					x = double.Parse(text1.Text.ToString());
					y = double.Parse(text2.Text.ToString());
					Sum = x + y;
					view.Text = Sum.ToString();

				}

				catch (FormatException)
				{

					view.Text = "Please enter a valid numbers ";

				}


			};
			subtract.Click +=
				delegate
				{
					try
					{
						double x = 0;
						double y = 0;
						x = double.Parse(text1.Text.ToString());
						y = double.Parse(text2.Text.ToString());
						Sum = x - y;
						view.Text = Sum.ToString();
					}


					catch (FormatException)
					{
						view.Text = "Please enter a valid numbers ";
					}

				};
			devide.Click +=
					delegate
					{
						try
						{
							double x = 0;
							double y = 0;
							x = double.Parse(text1.Text.ToString());
							y = double.Parse(text2.Text.ToString());
							Sum = x / y;
							view.Text = Sum.ToString();
						}


						catch (FormatException)
						{
							view.Text = "Please enter a valid numbers ";
						}

					};
			multiply.Click +=
					delegate
					{
						try
						{
							double x = 0;
							double y = 0;
							x = double.Parse(text1.Text.ToString());
							y = double.Parse(text2.Text.ToString());
							Sum = x * y;
							view.Text = Sum.ToString();
						}


						catch (FormatException)
						{
							view.Text = "Please enter a valid numbers ";
						}

					};
		}
	}
}
