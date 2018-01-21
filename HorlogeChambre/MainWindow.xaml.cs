using System;
using System.Configuration;
using System.Reflection;
using System.Windows;
using Microsoft.Win32;

namespace Samuarcher.HorlogeChambre
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		readonly RegistryKey _rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

		public MainWindow()
		{
			this.DataContext = new MainWindowModel();
			this.InitializeComponent();
			this.Loaded += this.OnLoaded;
			if (this._rkApp.GetValue("HorlogeChambre") == null && ConfigurationManager.AppSettings["LaunchStartup"] == "T")
			{
				this._rkApp.SetValue("HorlogeChambre", Assembly.GetExecutingAssembly().Location);
			}

			if (this._rkApp.GetValue("HorlogeChambre") != null && ConfigurationManager.AppSettings["LaunchStartup"] == "F")
			{
				this._rkApp.DeleteValue("HorlogeChambre", false);
			}
		}

		private void OnLoaded(object sender, EventArgs eventArgs)
		{
			((MainWindowModel)this.DataContext).SetTask();
		}

		private void CloseWindow(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
