using Microsoft.Maui.Controls.Shapes;

namespace AndroidBorderCornerBug {
    public partial class App : Application {
        public App() {

            ContentPage page = new();
            MainPage = page;
            page.BackgroundColor = Colors.DeepSkyBlue;
            AbsoluteLayout abs = new();
            page.Content = abs;

            AbsoluteLayout mainAbs = new();
            abs.Add(mainAbs);

            Border border = new();
            border.TranslationX = border.TranslationY = 20;
            border.WidthRequest = border.HeightRequest = 100;
            border.Stroke = Colors.White;
            border.BackgroundColor = Colors.White;
            border.StrokeThickness = 9;
            border.StrokeShape = new RoundRectangle() { CornerRadius = 10 };
            mainAbs.Add(border);

            AbsoluteLayout borderAbs = new();
            border.Content = borderAbs;

            Image image = new();
            image.WidthRequest = image.HeightRequest = 200;
            image.BackgroundColor = Colors.Red;
            borderAbs.Add(image);

        }
    }
}
