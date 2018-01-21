using System;
using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel
{
	public class RecuperationHumidite : IRecuperationHumidite
	{
		private readonly IJeedomRepository _jeedomRepository;
		private const string ID_HUMIDITE_EXTERIEUR = "140";
	    private const string ID_HUMIDITE_NEST = "68";

        public RecuperationHumidite(IJeedomRepository jeedomRepository)
		{
			this._jeedomRepository = jeedomRepository;
		}

		public double GetExterieur()
		{
			string humidite = this._jeedomRepository.GetInfoCommande(ID_HUMIDITE_EXTERIEUR);

			return Convert.ToDouble(humidite.Replace(".", ","));
        }

	    public double GetNest()
	    {
	        string humidite = this._jeedomRepository.GetInfoCommande(ID_HUMIDITE_NEST);

	        return Convert.ToDouble(humidite.Replace(".", ","));
        }
	}
}