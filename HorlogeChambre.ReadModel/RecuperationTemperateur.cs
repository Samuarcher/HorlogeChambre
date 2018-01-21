using System;
using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel
{
	public class RecuperationTemperateur : IRecuperationTemperature
	{
		private readonly IJeedomRepository _jeedomRepository;
		private const string ID_TEMPERATURE_NEST = "67";
		private const string ID_CONSIGNE_NEST = "72";
		private const string ID_TEMPERATURE_EXTERIEUR = "141";

		public RecuperationTemperateur(IJeedomRepository jeedomRepository)
		{
			this._jeedomRepository = jeedomRepository;
		}

		public double GetExterieur()
		{
			string tempExterieur = this._jeedomRepository.GetInfoCommande(ID_TEMPERATURE_EXTERIEUR);

			return Convert.ToDouble(tempExterieur.Replace(".", ","));
		}

		public double GetTemperatureNest()
		{
		    string temperatureNest = this._jeedomRepository.GetInfoCommande(ID_TEMPERATURE_NEST);

			return Convert.ToDouble(temperatureNest.Replace(".", ","));
        }

		public double GetConsigneNest()
		{
		    string consigneNest = this._jeedomRepository.GetInfoCommande(ID_CONSIGNE_NEST);

			return Convert.ToDouble(consigneNest.Replace(".", ","));
        }
	}
}