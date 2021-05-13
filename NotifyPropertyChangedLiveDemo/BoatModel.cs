using System.ComponentModel;

namespace NotifyPropertyChangedLiveDemo
{
    public partial class BoatModel : INotifyPropertyChanged
    {
        private double SpeedKmPerHourBackingField;
        private int NumberOfDoorsBackingField;
        private string ModelBackingField = "";
        private string DamienName3BackingField = "";
        private string DamienName4BackingField = "";
    
    

        public void SpeedUp() => SpeedKmPerHour *= 1.1;
    }
}