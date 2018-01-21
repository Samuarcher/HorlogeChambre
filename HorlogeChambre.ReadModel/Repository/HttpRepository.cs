using System.Net;

namespace Samuarcher.HorlogeChambre.ReadModel.Repository
{
	public static class HttpRepository
	{
		public static string Get(string url)
		{
			string result;

			using (WebClient client = new WebClient())
			{
				result = client.DownloadString(url);
			}

			return result;
		}
	}
}