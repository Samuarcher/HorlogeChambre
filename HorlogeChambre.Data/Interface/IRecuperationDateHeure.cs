using System;

namespace Samuarcher.HorlogeChambre.Data.Interface
{
	public interface IRecuperationDateHeure
	{
		DateTime GetDateJour();
		DateTime GetLeverSoleil();
		DateTime GetCoucherSoleil();
	}
}