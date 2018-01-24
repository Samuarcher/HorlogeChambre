using System;
using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel
{
	public class RecuperationTemperateur : IRecuperationTemperature
	{
		private readonly IJeedomRepository _jeedomRepository;
		private const string IdTemperatureNest = "67";
		private const string IdConsigneNest = "72";
		private const string IdTemperatureExterieur = "141";
		private const string IdSejour = "11";

		public RecuperationTemperateur(IJeedomRepository jeedomRepository)
		{
			this._jeedomRepository = jeedomRepository;
		}

		public double GetExterieur()
		{
			string tempExterieur = this._jeedomRepository.GetInfoCommande(IdTemperatureExterieur);

			return Convert.ToDouble(tempExterieur.Replace(".", ","));
		}

		public double GetTemperatureNest()
		{
		    string temperatureNest = this._jeedomRepository.GetInfoCommande(IdTemperatureNest);

			return Convert.ToDouble(temperatureNest.Replace(".", ","));
        }

		public double GetConsigneNest()
		{
		    string consigneNest = this._jeedomRepository.GetInfoCommande(IdConsigneNest);

			return Convert.ToDouble(consigneNest.Replace(".", ","));
        }

		public double GetSejour()
		{
			string sejour = this._jeedomRepository.GetInfoCommande(IdSejour);

			return Convert.ToDouble(sejour.Replace(".", ","));
		}
	}
}