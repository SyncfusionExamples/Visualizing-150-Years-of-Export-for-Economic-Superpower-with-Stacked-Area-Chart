using Syncfusion.Maui.Charts;
using System.Globalization;

namespace StackedAreaBlog
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
#if WINDOWS || MACCATALYST
            textAnnotation.Text = "In the late 1800s, the UK was the world's \nlargest exporter by value. By 2022, it had \nshrunk to the 15th largest.";
#endif

#if WINDOWS || MACCATALYST
            japanText.Text = "Japan's growth in electronic goods production \nbriefly made it one of the world's largest\nexporters.";
#endif

#if WINDOWS || MACCATALYST
            titleText.Text = "100+ Years of Global Trade: Economic Superpowers";
#else
            titleText.Text = "100+ Years of Global Trade";
#endif
        }
    }

}

