using System.Linq;
using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;
using Samuarcher.HorlogeChambre.Data.OpenWeatherMap;

namespace Samuarcher.HorlogeChambre.ReadModel
{
	public class RecuperationMeteo : IRecuperationMeteo
	{
		private readonly IOpenWeatherMapRepository _openWeatherMapRepository;

		public RecuperationMeteo(IOpenWeatherMapRepository openWeatherMapRepository)
		{
			this._openWeatherMapRepository = openWeatherMapRepository;
		}

		public string GetImagePath()
		{
			OpenWeatherMap openWeatherMap = this._openWeatherMapRepository.GetOpenWeatherMap();

			Weather weather = openWeatherMap?.Weather.FirstOrDefault();
			if (weather == null)
				return null;

			string urlImage = $@"http://openweathermap.org/img/w/{weather.Icon}.png";

			return urlImage;
		}

		public string GetImageLunePath()
		{
			return @"http://api.calendrier-lunaire.net/moon.php?bg_color=000000&size=200&font_color=FFFFFF";
		}
	}
}