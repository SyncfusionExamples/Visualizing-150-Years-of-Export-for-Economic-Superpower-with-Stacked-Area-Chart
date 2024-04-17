using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackedAreaBlog
{
    public class ViewModel
    {
     
        public ObservableCollection<Model> StackedData { get; set; }
       

        public ViewModel()
        {

            StackedData = new ObservableCollection<Model>();
            StackedData.Add(new Model() { Year = new DateTime(1870,01,01),UK= 24.3,Germany=13.4,US=5.0,Japan=0.1,China=2.8});
            StackedData.Add(new Model() { Year = new DateTime(1913, 01, 01),UK=18.5,Germany=18.0,US=9.0,Japan=0.8,China=2.0 });
            StackedData.Add(new Model() { Year = new DateTime(1929, 01, 01),UK=12.2,Germany=13.3,US=11.5,Japan=1.7,China=2.4 });
            StackedData.Add(new Model() { Year = new DateTime(1948, 01, 01),UK=11.3,Germany=1.4,US=21.6,Japan=0.4,China=0.9 });
            StackedData.Add(new Model() { Year = new DateTime(1950, 01, 01),UK=13.3,Germany=4.5,US=14.6,Japan=1.2,China=2.1 });
            StackedData.Add(new Model() { Year = new DateTime(1953, 01, 01),UK=9.0,Germany=5.3,US=14.6,Japan=1.5,China=1.2 });
            StackedData.Add(new Model() { Year = new DateTime(1963, 01, 01),UK=7.8,Germany=9.3,US=14.3,Japan=3.5,China=1.3 });
            StackedData.Add(new Model() { Year = new DateTime(1973, 01, 01),UK=5.6,Germany=11.5,US=10.3,Japan=5.6,China=0.7 });
            StackedData.Add(new Model() { Year = new DateTime(1983, 01, 01),UK=5.0,Germany=9.2,US=11.2,Japan=8.0,China=1.2 });
            StackedData.Add(new Model() { Year = new DateTime(1990, 01, 01),UK=5.3,Germany=12.0,US=11.3,Japan=8.2,China=1.8 });
            StackedData.Add(new Model() { Year = new DateTime(1993, 01, 01) ,UK=4.9,Germany=10.3,US=12.6,Japan=9.8,China=2.5});
            StackedData.Add(new Model() { Year = new DateTime(1998, 01, 01),UK=5.0,Germany=9.9,US=12.4,Japan=7.0,China=3.3 });
            StackedData.Add(new Model() { Year = new DateTime(2000, 01, 01),UK=4.4,Germany=8.5,US=12.1,Japan=7.4,China=3.9 });
            StackedData.Add(new Model() { Year = new DateTime(2003, 01, 01),UK=4.2,Germany=10.2,US=9.8,Japan=6.4,China=5.9 });
            StackedData.Add(new Model() { Year = new DateTime(2010, 01, 01),UK=2.7,Germany=8.2,US=8.4,Japan=5.0,China=10.3 });
            StackedData.Add(new Model() { Year = new DateTime(2012, 01, 01),UK=2.6,Germany=7.6,US=8.4,Japan=4.3,China=11.1 });
            StackedData.Add(new Model() { Year = new DateTime(2019, 01, 01),UK=2.4,Germany=7.8,US=8.6,Japan=3.7,China=13.2 });
            StackedData.Add(new Model() { Year = new DateTime(2022, 01, 01),UK=2.2,Germany=6.8,US=8.5,Japan=3.1,China=14.8 });
        }

    }
}
