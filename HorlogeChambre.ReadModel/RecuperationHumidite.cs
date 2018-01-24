using System;
using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel
{
	public class RecuperationHumidite : IRecuperationHumidite
	{
		private readonly IJeedomRepository _jeedomRepository;
		private const string IdHumiditeExterieur = "140";
	    private const string IdHumiditeNest = "68";

        public RecuperationHumidite(IJeedomRepository jeedomRepository)
		{
			this._jeedomRepository = jeedomRepository;
		}

		public double GetExterieur()
		{
			string humidite = this._jeedomRepository.GetInfoCommande(IdHumiditeExterieur);

			return Convert.ToDouble(humidite.Replace(".", ","));
        }

	    public double GetNest()
	    {
	        string humidite = this._jeedomRepository.GetInfoCommande(IdHumiditeNest);

	        return Convert.ToDouble(humidite.Replace(".", ","));
        }
	}
}