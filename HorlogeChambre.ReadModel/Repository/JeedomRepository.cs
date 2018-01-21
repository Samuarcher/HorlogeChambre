using Samuarcher.HorlogeChambre.Data.Interface.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel.Repository
{
    public class JeedomRepository : IJeedomRepository
    {
        private const string URL = "http://192.168.1.160/core/api/jeeApi.php?apikey=M6AZyHRb2ueNPDhhLxhKap3174CWOxmb";

        public string GetInfoCommande(string id)
        {
            string url = this.AddParam(URL, "type", "cmd");
            url = this.AddParam(url, "id", id);
            return HttpRepository.Get(url);
        }

        private string AddParam(string url, string key, string valeur)
        {
            return url + "&" + key + "=" + valeur;
        }
    }
}