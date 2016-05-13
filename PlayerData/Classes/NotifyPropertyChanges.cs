using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;

namespace PlayerData.Classes
{
    public abstract class NotifyPropertyChanges : INotifyPropertyChanged
    {
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add    { this.propertyChanged += value; }
            remove { this.propertyChanged -= value; }
        }

        private event PropertyChangedEventHandler propertyChanged;

        public IObservable<string> WhenPropertyChanged
        {
            get
            {
                return Observable.FromEventPattern<PropertyChangedEventHandler, PropertyChangedEventArgs>( h => propertyChanged += h
                                                                                                          ,h => propertyChanged -= h)
                                 .Select(x => x.EventArgs.PropertyName);
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
