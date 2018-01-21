using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Samuarcher.HorlogeChambre.UI
{
	public class ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}