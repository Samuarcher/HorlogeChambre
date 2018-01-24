using System;
using Samuarcher.HorlogeChambre.Data.Interface;

namespace Samuarcher.HorlogeChambre.UI.ViewModels
{
	public class Colonne3ViewModel : ColonneViewModel
	{
		private readonly IRecuperationTemperature _recuperationTemperature;
		private readonly IRecuperationHumidite _recuperationHumidite;
		private readonly IRecuperationLuminosite _recuperationLuminosite;

		private double _humiditeExterieur;
	    private double _temperatureNest;
	    private double _humiditeNest;
	    private double _consigneNest;
	    private double _temperatureExterieur;
		private double _temperatureSejour;
		private double _luminositeSejour;


		public double TemperatureNest
		{
			get => this._temperatureNest;
			set
			{
				this._temperatureNest = value;
				this.RaisePropertyChanged();
			}
	    }
        
	    public double HumiditeNest
	    {
	        get => this._humiditeNest;
	        set
	        {
	            this._humiditeNest = value;
	            this.RaisePropertyChanged();
	        }
	    }

		public double ConsigneNest
		{
			get => this._consigneNest;
			set
			{
				this._consigneNest = value;
				this.RaisePropertyChanged();
			}
		}

		public double TemperatureSejour
		{
			get => this._temperatureSejour;
			set
			{
				this._temperatureSejour = value;
				this.RaisePropertyChanged();
			}
		}

		public double LuminositeSejour
		{
			get => this._luminositeSejour;
			set
			{
				this._luminositeSejour = value;
				this.RaisePropertyChanged();
			}
		}
        
		public double TemperatureExterieur
		{
			get => this._temperatureExterieur;
			set
			{
				this._temperatureExterieur = value;
				this.RaisePropertyChanged();
			}
		}

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
			IRecuperationHumidite recuperationHumidite,
			IRecuperationLuminosite recuperationLuminosite)
		{
			this._recuperationTemperature = recuperationTemperature;
			this._recuperationHumidite = recuperationHumidite;
			this._recuperationLuminosite = recuperationLuminosite;
		}

		public override void SetTask()
		{
			PeriodicTask.Run(() => this.TemperatureNest = this._recuperationTemperature.GetTemperatureNest(), TimeSpan.FromMinutes(10));
		    PeriodicTask.Run(() => this.HumiditeNest = this._recuperationHumidite.GetNest(), TimeSpan.FromMinutes(10));
            PeriodicTask.Run(() => this.ConsigneNest = this._recuperationTemperature.GetConsigneNest(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(() => this.TemperatureSejour = this._recuperationTemperature.GetSejour(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(() => this.LuminositeSejour = this._recuperationLuminosite.GetSejour(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(() => this.TemperatureExterieur = this._recuperationTemperature.GetExterieur(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(() => this.HumiditeExterieur = this._recuperationHumidite.GetExterieur(), TimeSpan.FromMinutes(10));
        }
	}
}