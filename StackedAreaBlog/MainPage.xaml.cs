using Syncfusion.Maui.Charts;
using Syncfusion.Maui.Graphics.Internals;
using System.Collections.ObjectModel;
using System.Globalization;

namespace StackedAreaBlog
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
    }

    public class Converter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var model = parameter as ExportViewModel;

            var count = model.ExportData.Count;

            if (values[0] is int index)
            {
                var labelText = values[1] as string;
                if (index == 0 || index == count - 1)
                {
                    return labelText + "%" ?? null;
                }
            }

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }

    }

    public class StackingAreaExt : StackingAreaSeries
    {
        internal ChartLabelStyle LabelStyle { get; set; }
        public StackingAreaExt()
        {
            LabelStyle = new ChartLabelStyle() { FontSize = 20, TextColor = Colors.White };
        }
        protected override ChartSegment? CreateSegment()
        {
            return new StackingAreaSegmentExt();
        }

    }

    public class StackingAreaSegmentExt : StackingAreaSegment
    {
        private double pointHeightWidth = 10;
        private double firstLabel;
        private double secondLabel;
        private double thirdLabel;
        private double fourthLabel;
        private double fifthLabel;
        private double sixthLabel;

        private double xPosChina;
        private double yPosChina;

        private double xPosUS;
        private double yPosUS ;

        private double xPosGermany;
        private double yPosGermany;

        private double xPosJapan;
        private double yPosJapan ;

        private double xPosUK;
        private double yPosUK;

        private float xPosEllipse;
        private float yPosEllipse;
        private float yPosLine;

        private float xPos;
        private float yPos;


        private string? segmentName;
        private string? uKDescription = "In the late 1880s, the UK was the world \n largest exporter by value. By 2022, \n it has shrunk to 15th largest.";

        protected override void OnLayout()
        {
            base.OnLayout();
            if (Series is StackingAreaExt series)
            {
                var style = series.LabelStyle;
                style.Parent = series.ActualYAxis!.Parent;
                segmentName = series.Label;
                CalculateTextPosition(series,segmentName);
            }
        }

        private void CalculateTextPosition(StackingAreaExt series,string segmentName)
        {
            switch (segmentName)
            {
                case "CHINA":
                    firstLabel = new DateTime(2005, 01, 01).ToOADate();
                    xPosChina = series.ActualXAxis.ValueToPoint(firstLabel);
                    yPosChina = series.ActualYAxis.ValueToPoint(5.9);
                    break;
                case "U.S.":
                    secondLabel = new DateTime(1940, 01, 01).ToOADate();
                    xPosUS = series.ActualXAxis.ValueToPoint(secondLabel);
                    yPosUS = series.ActualYAxis.ValueToPoint(11.8);
                    break;
                case "GERMANY":
                    thirdLabel = new DateTime(1910, 01, 01).ToOADate();
                    xPosGermany = series.ActualXAxis.ValueToPoint(thirdLabel);
                    yPosGermany = series.ActualYAxis.ValueToPoint(22);
                    break;
                case "JAPAN":
                    fourthLabel = new DateTime(1990, 01, 01).ToOADate();
                    xPosJapan = series.ActualXAxis.ValueToPoint(fourthLabel);
                    yPosJapan = series.ActualYAxis.ValueToPoint(32);

                    
                    break;
                case "UK":
                    fifthLabel = new DateTime(1915, 01, 01).ToOADate();
                    xPosUK = series.ActualXAxis.ValueToPoint(fifthLabel);
                    yPosUK = series.ActualYAxis.ValueToPoint(45);

                    sixthLabel = new DateTime(1905, 01, 01).ToOADate();
                    xPos = series.ActualXAxis.ValueToPoint(sixthLabel);
                    yPos = series.ActualYAxis.ValueToPoint(40);

                    var x1 = new DateTime(1992, 10, 01).ToOADate();
                    xPosEllipse = series.ActualXAxis.ValueToPoint(x1);
                    yPosEllipse = series.ActualYAxis.ValueToPoint(35);
                    yPosLine = series.ActualYAxis.ValueToPoint(43);
                    break;
            }
        }

        protected override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);

            if (Series is StackingAreaExt series)
            {
                var style = series.LabelStyle;
                var newStyle = new ChartLabelStyle() { FontSize = 12, TextColor = Colors.White };
                newStyle.Parent = series.ActualYAxis!.Parent;

                canvas.SaveState();

                switch (segmentName)
                {
                    case "CHINA":
                        canvas.DrawText(segmentName, (float)xPosChina, (float)yPosChina, style);
                        break;
                    case "U.S.":
                        canvas.DrawText(segmentName, (float)xPosUS, (float)yPosUS, style);
                        break;
                    case "GERMANY":
                        canvas.DrawText(segmentName, (float)xPosGermany, (float)yPosGermany, style);
                        break;
                    case "JAPAN":
                        canvas.DrawText(segmentName, (float)xPosJapan, (float)yPosJapan, style);                     
                        break;
                    case "UK":
                        canvas.DrawText(segmentName, (float)xPosUK, (float)yPosUK, style);
                        canvas.DrawText(uKDescription, xPos, yPos, newStyle);
                        canvas.StrokeColor = Color.FromArgb("#FFC943");
                        canvas.FillColor = Color.FromArgb("#FFC943");
                        var rect = new Rect(xPosEllipse - (pointHeightWidth / 2), yPosEllipse - (pointHeightWidth / 2), pointHeightWidth, pointHeightWidth);
                        canvas.FillEllipse(rect);
                        canvas.DrawLine(xPosEllipse, yPosEllipse, xPosEllipse, yPosLine);
                        break;
                }

                canvas.RestoreState();
            }
        }
    }
}
