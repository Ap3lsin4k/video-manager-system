using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace VMS.ViewModel
{
    class MainViewModel : INotifyPropertyChanged // Вьюмодель для окна MainWindow
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
