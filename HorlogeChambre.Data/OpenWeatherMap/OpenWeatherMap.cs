﻿using System.Collections.Generic;

namespace Samuarcher.HorlogeChambre.Data.OpenWeatherMap
{
	public class OpenWeatherMap
	{
		public Coordonnee Coord { get; set; }
		public IEnumerable<Weather> Weather { get; set; }
		public string Base { get; set; }
		public Main Main { get; set; }
		public string Visibility { get; set; }
		public Wind Wind { get; set; }
		public Clouds Clouds { get; set; }
		public long Dt { get; set; }
		public Sys Sys { get; set; }
		public long Id { get; set; }
		public string Name { get; set; }
		public long Cod { get; set; }
	}
}