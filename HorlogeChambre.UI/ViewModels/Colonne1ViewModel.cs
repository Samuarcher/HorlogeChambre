using System;
using Samuarcher.HorlogeChambre.Data.Interface;

namespace Samuarcher.HorlogeChambre.UI.ViewModels
{
	public class Colonne1ViewModel : ColonneViewModel
	{
		private readonly IRecuperationDateHeure _recuperationDateHeure;
		private readonly IRecuperationTrajet _recuperationTrajet;
		private DateTime _dateJour;
		private DateTime _leverSoleil;
		private DateTime _coucherSoleil;
		private string _libelleTrajet1;
		private string _dureeTrajet1;
		private string _libelleTrajet2;
		private string _dureeTrajet2;
		private string _libelleTrajet3;
		private string _dureeTrajet3;

		public DateTime DateJour
		{
			get => this._dateJour;
			set
			{
				this._dateJour = value;
				this.RaisePropertyChanged();
			}
		}

		public DateTime LeverSoleil
		{
			get => this._leverSoleil;
			set
			{
				this._leverSoleil = value;
				this.RaisePropertyChanged();
			}
		}

		public DateTime CoucherSoleil
		{
			get => this._coucherSoleil;
			set
			{
				this._coucherSoleil = value;
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

		public Colonne1ViewModel(IRecuperationDateHeure recuperationDateHeure,
			IRecuperationTrajet recuperationTrajet)
		{
			this._recuperationDateHeure = recuperationDateHeure;
			this._recuperationTrajet = recuperationTrajet;
		}

		public override void SetTask()
		{
			PeriodicTask.Run(() => this.DateJour = this._recuperationDateHeure.GetDateJour(), TimeSpan.FromSeconds(1));
			PeriodicTask.Run(() => this.LeverSoleil = this._recuperationDateHeure.GetLeverSoleil(), TimeSpan.FromHours(1));
			PeriodicTask.Run(() => this.CoucherSoleil = this._recuperationDateHeure.GetCoucherSoleil(), TimeSpan.FromHours(1));
			PeriodicTask.Run(() => this.LibelleTrajet1 = this._recuperationTrajet.GetLibelleTrajet1(), TimeSpan.FromMinutes(5));
			PeriodicTask.Run(() => this.LibelleTrajet2 = this._recuperationTrajet.GetLibelleTrajet2(), TimeSpan.FromMinutes(5));
			PeriodicTask.Run(() => this.LibelleTrajet3 = this._recuperationTrajet.GetLibelleTrajet3(), TimeSpan.FromMinutes(5));
			PeriodicTask.Run(() => this.DureeTrajet1 = this._recuperationTrajet.GetDureeTrajet1(), TimeSpan.FromMinutes(5));
			PeriodicTask.Run(() => this.DureeTrajet2 = this._recuperationTrajet.GetDureeTrajet2(), TimeSpan.FromMinutes(5));
			PeriodicTask.Run(() => this.DureeTrajet3 = this._recuperationTrajet.GetDureeTrajet3(), TimeSpan.FromMinutes(5));
		}
	}
}