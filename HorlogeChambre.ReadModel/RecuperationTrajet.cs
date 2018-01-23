using Samuarcher.HorlogeChambre.Data.Interface;
using Samuarcher.HorlogeChambre.Data.Interface.Repository;

namespace Samuarcher.HorlogeChambre.ReadModel
{
    public class RecuperationTrajet : IRecuperationTrajet
    {
        private readonly IJeedomRepository _jeedomRepository;
        private const string ID_LIBELLE_TRAJET_1 = "192";
        private const string ID_DUREE_TRAJET_1 = "193";
        private const string ID_LIBELLE_TRAJET_2 = "194";
        private const string ID_DUREE_TRAJET_2 = "195";
        private const string ID_LIBELLE_TRAJET_3 = "196";
        private const string ID_DUREE_TRAJET_3 = "197";

        public RecuperationTrajet(IJeedomRepository jeedomRepository)
        {
            this._jeedomRepository = jeedomRepository;
        }

        public string GetLibelleTrajet1()
        {
            return this._jeedomRepository.GetInfoCommande(ID_LIBELLE_TRAJET_1);
        }

        public string GetDureeTrajet1()
        {
            return this._jeedomRepository.GetInfoCommande(ID_DUREE_TRAJET_1);
        }

        public string GetLibelleTrajet2()
        {
            return this._jeedomRepository.GetInfoCommande(ID_LIBELLE_TRAJET_2);
        }

        public string GetDureeTrajet2()
        {
            return this._jeedomRepository.GetInfoCommande(ID_DUREE_TRAJET_2);
        }

        public string GetLibelleTrajet3()
        {
            return this._jeedomRepository.GetInfoCommande(ID_LIBELLE_TRAJET_3);
        }

        public string GetDureeTrajet3()
        {
            return this._jeedomRepository.GetInfoCommande(ID_DUREE_TRAJET_3);
        }
    }
}