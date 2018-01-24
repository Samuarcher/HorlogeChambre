using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel
{
    public class RecuperationTrajet : IRecuperationTrajet
    {
        private readonly IJeedomRepository _jeedomRepository;
        private const string IdLibelleTrajet1 = "192";
        private const string IdDureeTrajet1 = "193";
        private const string IdLibelleTrajet2 = "194";
        private const string IdDureeTrajet2 = "195";
        private const string IdLibelleTrajet3 = "196";
        private const string IdDureeTrajet3 = "197";

        public RecuperationTrajet(IJeedomRepository jeedomRepository)
        {
            this._jeedomRepository = jeedomRepository;
        }

        public string GetLibelleTrajet1()
        {
            return this._jeedomRepository.GetInfoCommande(IdLibelleTrajet1);
        }

        public string GetDureeTrajet1()
        {
            return this._jeedomRepository.GetInfoCommande(IdDureeTrajet1);
        }

        public string GetLibelleTrajet2()
        {
            return this._jeedomRepository.GetInfoCommande(IdLibelleTrajet2);
        }

        public string GetDureeTrajet2()
        {
            return this._jeedomRepository.GetInfoCommande(IdDureeTrajet2);
        }

        public string GetLibelleTrajet3()
        {
            return this._jeedomRepository.GetInfoCommande(IdLibelleTrajet3);
        }

        public string GetDureeTrajet3()
        {
            return this._jeedomRepository.GetInfoCommande(IdDureeTrajet3);
        }
    }
}