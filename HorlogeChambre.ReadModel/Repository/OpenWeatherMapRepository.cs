using System;
using Newtonsoft.Json;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;
using Samuarcher.HorlogeChambre.Data.OpenWeatherMap;

namespace Samuarcher.HorlogeChambre.ReadModel.Repository
{
	public class OpenWeatherMapRepository : IOpenWeatherMapRepository
	{
		private const string API_KEY = "433febe32eafaee7dcf847c9bca0fee9";
		private const string ID_VILLE = "3000192";

		public OpenWeatherMap GetOpenWeatherMap()
		{
			var url = $"http://api.openweathermap.org/data/2.5/weather?id={ID_VILLE}&APPID={API_KEY}&units=metric";

			string json = HttpRepository.Get(url);

			if (String.IsNullOrWhiteSpace(json))
				return null;

			OpenWeatherMap openWeatherMap = null;
			try
			{
				openWeatherMap = JsonConvert.DeserializeObject<OpenWeatherMap>(json);
			}
			catch (Exception e)
			{
				return null;
			}

			return openWeatherMap;
		}
	}
}