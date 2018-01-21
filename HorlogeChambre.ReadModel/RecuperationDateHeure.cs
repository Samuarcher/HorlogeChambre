using System;
using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;
using Samuarcher.HorlogeChambre.Data.OpenWeatherMap;
using Samuarcher.HorlogeChambre.ReadModel.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel
{
	public class RecuperationDateHeure : IRecuperationDateHeure
	{
		private readonly IOpenWeatherMapRepository _openWeatherMapRepository;

		public RecuperationDateHeure(IOpenWeatherMapRepository openWeatherMapRepository)
		{
			this._openWeatherMapRepository = openWeatherMapRepository;
		}

		private DateTime GetDateTime(long unixTimeStamp)
		{
			DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
			return dtDateTime;
		}

		public DateTime GetDateJour()
		{
			return DateTime.Now;
		}

		public DateTime GetLeverSoleil()
		{
			OpenWeatherMap openWeatherMap = this._openWeatherMapRepository.GetOpenWeatherMap();

			return this.GetDateTime(openWeatherMap.sys.sunrise);
		}

		public DateTime GetCoucherSoleil()
		{
			OpenWeatherMap openWeatherMap = this._openWeatherMapRepository.GetOpenWeatherMap();

			return this.GetDateTime(openWeatherMap.sys.sunset);
		}
	}
}