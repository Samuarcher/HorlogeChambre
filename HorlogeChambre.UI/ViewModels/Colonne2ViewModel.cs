using System;
using Samuarcher.HorlogeChambre.Data.Interface;

namespace Samuarcher.HorlogeChambre.UI.ViewModels
{
	public class Colonne2ViewModel : ColonneViewModel
	{
		private readonly IRecuperationMeteo _recuperationMeteo;
		
		private string _meteoImagePath;
		public string MeteoImagePath
		{
			get => this._meteoImagePath;
			set
			{
				this._meteoImagePath = value;
				this.RaisePropertyChanged();
			}
		}

		private string _luneImagePath;
		public string LuneImagePath
		{
			get => this._luneImagePath;
			set
			{
				this._luneImagePath = value;
				this.RaisePropertyChanged();
			}
		}

		public Colonne2ViewModel(IRecuperationMeteo recuperationMeteo)
		{
			this._recuperationMeteo = recuperationMeteo;
		}

		public override void SetTask()
		{
			PeriodicTask.Run(() => this.MeteoImagePath = this._recuperationMeteo.GetImagePath(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(this.SetUrlImageLune, TimeSpan.FromHours(1));
		}

		private void SetUrlImageLune()
		{
			this.LuneImagePath = String.Empty;
			this.LuneImagePath = this._recuperationMeteo.GetImageLunePath();
		}
	}
}