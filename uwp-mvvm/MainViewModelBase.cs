using System.ComponentModel;

namespace uwp_mvvm
{
    public abstract class MainViewModelBase : INotifyPropertyChanged
    {
        // INotifyPropertyChangedは必ずこのイベントをもっていなければならない
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}