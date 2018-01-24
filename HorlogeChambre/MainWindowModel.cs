using Samuarcher.HorlogeChambre.ReadModel;
using Samuarcher.HorlogeChambre.ReadModel.Repository;
using Samuarcher.HorlogeChambre.UI;
using Samuarcher.HorlogeChambre.UI.ViewModels;

namespace Samuarcher.HorlogeChambre
{
	public class MainWindowModel : ViewModel
	{
		public Colonne1ViewModel Colonne1 { get; set; }
		public Colonne2ViewModel Colonne2 { get; set; }
		public Colonne3ViewModel Colonne3 { get; set; }

		public MainWindowModel()
		{
			JeedomRepository jeedomRepository = new JeedomRepository();
			OpenWeatherMapRepository openWeatherMapRepository = new OpenWeatherMapRepository();

			this.Colonne1 = new Colonne1ViewModel(new RecuperationDateHeure(openWeatherMapRepository),
				new RecuperationTrajet(jeedomRepository));
			this.Colonne2 = new Colonne2ViewModel(new RecuperationMeteo(openWeatherMapRepository));
			this.Colonne3 = new Colonne3ViewModel(new RecuperationTemperateur(jeedomRepository),
				new RecuperationHumidite(jeedomRepository),
				new RecuperationLuminosite(jeedomRepository));
		}

		public void SetTask()
		{
			this.Colonne1.SetTask();
			this.Colonne2.SetTask();
			this.Colonne3.SetTask();
		}
	}
}