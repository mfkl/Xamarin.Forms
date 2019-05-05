using System;
using Xamarin.Forms.Platform.GTK;
using Xamarin.Forms.Sandbox;

namespace GTK.Bug
{
	public class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			global::Gtk.Application.Init();
			Xamarin.Forms.Forms.Init();

			var app = new App();
			var window = new FormsWindow();
			window.LoadApplication(app);
			window.SetApplicationTitle("GTK# Forms sample");
			window.Show();

			global::Gtk.Application.Run();
		}
	}
}
