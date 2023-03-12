using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchetrachodov4
{
    public class funcional : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string category;
        public string Category
        {
            get { return category; }
            set
            {
                if (category == value)
                    return;

                category = value;
                RaisePropertyChanged(nameof(Category));
            }
        }

        private double cash;
        public double Cash
        {
            get { return cash; }
            set
            {
                cash = value;
                RaisePropertyChanged("Cash");
            }
        }

        private double card1;
        public double Card1
        {
            get { return card1; }
            set
            {
                card1 = value;
                RaisePropertyChanged("Card1");
            }
        }

        private double card2;

        public double Card2
        {
            get { return card2; }
            set
            {
                card2 = value;
                RaisePropertyChanged("Card2");
            }
        }

        public static List<funcional> ConstructTestData()
        {
            List<funcional> assetClasses = new List<funcional>();
            assetClasses.Add(new funcional() { Category = "Food", Cash = 10001, Card1 = 500, Card2 = 400 });
            return assetClasses;
        }

        private void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
