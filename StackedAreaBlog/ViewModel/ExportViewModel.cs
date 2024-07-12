using System.Collections.ObjectModel;

namespace StackedAreaBlog
{
    public class ExportViewModel
    {
        public ObservableCollection<ExportModel> ExportData { get; set; }

        public ExportViewModel()
        {
            ExportData = new ObservableCollection<ExportModel>();
            ExportData.Add(new ExportModel() { Year = new DateTime(1913, 01, 01), China = 2.0, US = 9.0, Germany = 18.0, Japan = 0.8, UK = 18.5 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1929, 01, 01), China = 2.4, US = 11.5, Germany = 13.3, Japan = 1.7, UK = 12.2 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1950, 01, 01), China = 2.1, US = 14.6, Germany = 4.5, Japan = 1.2, UK = 13.3 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1973, 01, 01), China = 0.7, US = 10.3, Germany = 11.5, Japan = 5.6, UK = 5.6 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1990, 01, 01), China = 1.8, US = 11.3, Germany = 12.0, Japan = 8.2, UK = 5.3 });
            ExportData.Add(new ExportModel() { Year = new DateTime(1998, 01, 01), China = 3.3, US = 12.4, Germany = 9.9, Japan = 7.0, UK = 5.0 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2000, 01, 01), China = 3.9, US = 12.1, Germany = 8.5, Japan = 7.4, UK = 4.4 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2010, 01, 01), China = 10.3, US = 8.4, Germany = 8.2, Japan = 5.0, UK = 2.7 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2012, 01, 01), China = 11.1, US = 8.4, Germany = 7.6, Japan = 4.3, UK = 2.6 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2019, 01, 01), China = 13.2, US = 8.6, Germany = 7.8, Japan = 3.7, UK = 2.4 });
            ExportData.Add(new ExportModel() { Year = new DateTime(2022, 01, 01), China = 14.4, US = 8.3, Germany = 6.6, Japan = 3.0, UK = 2.1 });
        }
    }
}
