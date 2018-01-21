using System;
using Samuarcher.HorlogeChambre.Data.Interface;

namespace Samuarcher.HorlogeChambre.UI.ViewModels
{
	public class Colonne3ViewModel : ColonneViewModel
	{
		private readonly IRecuperationTemperature _recuperationTemperature;
		private readonly IRecuperationHumidite _recuperationHumidite;


		private double _temperatureNest;

		public double TemperatureNest
		{
			get => this._temperatureNest;
			set
			{
				this._temperatureNest = value;
				this.RaisePropertyChanged();
			}
	    }

	    private double _humiditeNest;

	    public double HumiditeNest
	    {
	        get => this._humiditeNest;
	        set
	        {
	            this._humiditeNest = value;
	            this.RaisePropertyChanged();
	        }
	    }

        private double _consigneNest;

		public double ConsigneNest
		{
			get => this._consigneNest;
			set
			{
				this._consigneNest = value;
				this.RaisePropertyChanged();
			}
		}

		private double _temperatureExterieur;

		public double TemperatureExterieur
		{
			get => this._temperatureExterieur;
			set
			{
				this._temperatureExterieur = value;
				this.RaisePropertyChanged();
			}
		}

		private double _humiditeExterieur;

		public double HumiditeExterieur
		{
			get => this._humiditeExterieur;
			set
			{
				this._humiditeExterieur = value;
				this.RaisePropertyChanged();
			}
		}

		public Colonne3ViewModel(IRecuperationTemperature recuperationTemperature,
			IRecuperationHumidite recuperationHumidite)
		{
			this._recuperationTemperature = recuperationTemperature;
			this._recuperationHumidite = recuperationHumidite;
		}

		public override void SetTask()
		{
			PeriodicTask.Run(() => this.TemperatureNest = this._recuperationTemperature.GetTemperatureNest(), TimeSpan.FromMinutes(10));
		    PeriodicTask.Run(() => this.HumiditeNest = this._recuperationHumidite.GetNest(), TimeSpan.FromMinutes(10));
            PeriodicTask.Run(() => this.ConsigneNest = this._recuperationTemperature.GetConsigneNest(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(() => this.TemperatureExterieur = this._recuperationTemperature.GetExterieur(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(() => this.HumiditeExterieur = this._recuperationHumidite.GetExterieur(), TimeSpan.FromMinutes(10));
		}
	}
}