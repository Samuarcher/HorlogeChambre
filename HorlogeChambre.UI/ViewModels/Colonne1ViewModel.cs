using System;
using Samuarcher.HorlogeChambre.Data.Interface;

namespace Samuarcher.HorlogeChambre.UI.ViewModels
{
	public class Colonne1ViewModel : ColonneViewModel
	{
		private readonly IRecuperationDateHeure _recuperationDateHeure;

		private DateTime _dateJour;
		public DateTime DateJour
		{
			get => this._dateJour;
			set
			{
				this._dateJour = value;
				this.RaisePropertyChanged();
			}
		}

		private DateTime _leverSoleil;
		public DateTime LeverSoleil
		{
			get => this._leverSoleil;
			set
			{
				this._leverSoleil = value;
				this.RaisePropertyChanged();
			}
		}

		private DateTime _coucherSoleil;
		public DateTime CoucherSoleil
		{
			get => this._coucherSoleil;
			set
			{
				this._coucherSoleil = value;
				this.RaisePropertyChanged();
			}
		}

		public Colonne1ViewModel(IRecuperationDateHeure recuperationDateHeure)
		{
			this._recuperationDateHeure = recuperationDateHeure;
		}

		public override void SetTask()
		{
			PeriodicTask.Run(() => this.DateJour = this._recuperationDateHeure.GetDateJour(), TimeSpan.FromSeconds(1));
			PeriodicTask.Run(() => this.LeverSoleil = this._recuperationDateHeure.GetLeverSoleil(), TimeSpan.FromHours(1));
			PeriodicTask.Run(() => this.CoucherSoleil = this._recuperationDateHeure.GetCoucherSoleil(), TimeSpan.FromHours(1));
		}
	}
}