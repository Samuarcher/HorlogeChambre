using System;
using Samuarcher.HorlogeChambre.Data.Interface;

namespace Samuarcher.HorlogeChambre.UI.ViewModels
{
	public class Colonne3ViewModel : ColonneViewModel
	{
		private readonly IRecuperationTemperature _recuperationTemperature;
		private readonly IRecuperationHumidite _recuperationHumidite;
	    private readonly IRecuperationTrajet _recuperationTrajet;

	    private double _humiditeExterieur;
	    private string _libelleTrajet1;
	    private string _dureeTrajet1;
	    private string _libelleTrajet2;
	    private string _dureeTrajet2;
	    private string _libelleTrajet3;
	    private string _dureeTrajet3;
	    private double _temperatureNest;
	    private double _humiditeNest;
	    private double _consigneNest;
	    private double _temperatureExterieur;

        
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

	    public string LibelleTrajet1
	    {
	        get => this._libelleTrajet1;
	        set
	        {
	            this._libelleTrajet1 = value;
	            this.RaisePropertyChanged();
            }
	    }

	    public string DureeTrajet1
	    {
	        get => this._dureeTrajet1;
	        set
	        {
	            this._dureeTrajet1 = value;
	            this.RaisePropertyChanged();
            }
	    }

	    public string LibelleTrajet2
	    {
	        get => this._libelleTrajet2;
	        set
	        {
	            this._libelleTrajet2 = value;
	            this.RaisePropertyChanged();
            }
	    }

	    public string DureeTrajet2
	    {
	        get => this._dureeTrajet2;
	        set
	        {
	            this._dureeTrajet2 = value;
	            this.RaisePropertyChanged();
            }
	    }

	    public string LibelleTrajet3
	    {
	        get => this._libelleTrajet3;
	        set
	        {
	            this._libelleTrajet3 = value;
	            this.RaisePropertyChanged();
            }
	    }

	    public string DureeTrajet3
	    {
	        get => this._dureeTrajet3;
	        set
	        {
	            this._dureeTrajet3 = value;
	            this.RaisePropertyChanged();
            }
	    }


	    public Colonne3ViewModel(IRecuperationTemperature recuperationTemperature,
			IRecuperationHumidite recuperationHumidite,
		    IRecuperationTrajet recuperationTrajet)
		{
			this._recuperationTemperature = recuperationTemperature;
			this._recuperationHumidite = recuperationHumidite;
		    this._recuperationTrajet = recuperationTrajet;
		}

		public override void SetTask()
		{
			PeriodicTask.Run(() => this.TemperatureNest = this._recuperationTemperature.GetTemperatureNest(), TimeSpan.FromMinutes(10));
		    PeriodicTask.Run(() => this.HumiditeNest = this._recuperationHumidite.GetNest(), TimeSpan.FromMinutes(10));
            PeriodicTask.Run(() => this.ConsigneNest = this._recuperationTemperature.GetConsigneNest(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(() => this.TemperatureExterieur = this._recuperationTemperature.GetExterieur(), TimeSpan.FromMinutes(10));
			PeriodicTask.Run(() => this.HumiditeExterieur = this._recuperationHumidite.GetExterieur(), TimeSpan.FromMinutes(10));
		    PeriodicTask.Run(() => this.LibelleTrajet1 = this._recuperationTrajet.GetLibelleTrajet1(), TimeSpan.FromMinutes(5));
		    PeriodicTask.Run(() => this.LibelleTrajet2 = this._recuperationTrajet.GetLibelleTrajet2(), TimeSpan.FromMinutes(5));
		    PeriodicTask.Run(() => this.LibelleTrajet3 = this._recuperationTrajet.GetLibelleTrajet3(), TimeSpan.FromMinutes(5));
		    PeriodicTask.Run(() => this.DureeTrajet1 = this._recuperationTrajet.GetDureeTrajet1(), TimeSpan.FromMinutes(5));
		    PeriodicTask.Run(() => this.DureeTrajet2 = this._recuperationTrajet.GetDureeTrajet2(), TimeSpan.FromMinutes(5));
            PeriodicTask.Run(() => this.DureeTrajet3 = this._recuperationTrajet.GetDureeTrajet3(), TimeSpan.FromMinutes(5));
        }
	}
}