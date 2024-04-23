using System.Collections.ObjectModel;

namespace StackedAreaBlog
{
    public class ExportViewModel
    {
        public ObservableCollection<ExportModel> ExportData { get; set; }

        public ExportViewModel()
        {

            ExportData = new ObservableCollection<ExportModel>();
            ExportData.Add(new ExportModel() { Year = new DateTime(1900, 01, 01), China = 2.8, US = 5.0, Germany = 13.4, Japan = 0.1, UK = 24.3 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1913, 01, 01), China = 2.0, US = 9.0, Germany = 18.0, Japan = 0.8, UK = 18.5 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1948, 01, 01), China = 0.9, US = 21.6, Germany = 1.4, Japan = 0.4, UK = 11.3 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1950, 01, 01), China = 2.1, US = 14.6, Germany = 4.5, Japan = 1.2, UK = 13.3 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1953, 01, 01), China = 1.2, US = 14.6, Germany = 5.3, Japan = 1.5, UK = 9.0 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1963, 01, 01), China = 1.3, US = 14.3, Germany = 9.3, Japan = 3.5, UK = 7.8 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1973, 01, 01), China = 0.7, US = 10.3, Germany = 11.5, Japan = 5.6, UK = 5.6 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1983, 01, 01), China = 1.2, US = 11.2, Germany = 9.2, Japan = 8.0, UK = 5.0 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1990, 01, 01), China = 1.8, US = 11.3, Germany = 12.0, Japan = 8.2, UK = 5.3 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1993, 01, 01), China = 2.5, US = 12.6, Germany = 10.3, Japan = 9.8, UK = 4.9 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1998, 01, 01), China = 3.3, US = 12.4, Germany = 9.9, Japan = 7.0, UK = 5.0 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2000, 01, 01), China = 3.9, US = 12.1, Germany = 8.5, Japan = 7.4, UK = 4.4 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2003, 01, 01), China = 5.9, US = 9.8, Germany = 10.2, Japan = 6.4, UK = 4.2 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2010, 01, 01), China = 10.3, US = 8.4, Germany = 8.2, Japan = 5.0, UK = 2.7 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2012, 01, 01), China = 11.1, US = 8.4, Germany = 7.6, Japan = 4.3, UK = 2.6 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2019, 01, 01), China = 13.2, US = 8.6, Germany = 7.8, Japan = 3.7, UK = 2.4 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2022, 01, 01), China = 14.8, US = 8.5, Germany = 6.8, Japan = 3.1, UK = 2.2 });
        }
    }
}
