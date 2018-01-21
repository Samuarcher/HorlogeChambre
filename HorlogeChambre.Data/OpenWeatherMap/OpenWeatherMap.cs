using System.Collections.Generic;

namespace Samuarcher.HorlogeChambre.Data.OpenWeatherMap
{
	public class OpenWeatherMap
	{
		public Coordonnee coord { get; set; }
		public IEnumerable<Weather> weather { get; set; }
		public string @base { get; set; }
		public Main main { get; set; }
		public string visibility { get; set; }
		public Wind wind { get; set; }
		public Clouds clouds { get; set; }
		public long dt { get; set; }
		public Sys sys { get; set; }
		public long id { get; set; }
		public string name { get; set; }
		public long cod { get; set; }
	}
}