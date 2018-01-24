using System;
using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel
{
	public class RecuperationLuminosite : IRecuperationLuminosite
	{
		private readonly IJeedomRepository _jeedomRepository;
		private const string IdLuminositeSejour = "12";

		public RecuperationLuminosite(IJeedomRepository jeedomRepository)
		{
			this._jeedomRepository = jeedomRepository;
		}

		public double GetSejour()
		{
			string luminosite = this._jeedomRepository.GetInfoCommande(IdLuminositeSejour);

			return Convert.ToDouble(luminosite.Replace(".", ","));
		}
	}
}