using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VMS.Models
{
    class SomeModel : INotifyPropertyChanged // Просто пример
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
