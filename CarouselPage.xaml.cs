namespace MauiApp_TARgv23;

public partial class CarouselPage : ContentPage
{
    Frame frame;

    public CarouselPage()
	{
        IndicatorView indicatorView = new IndicatorView
        {
            SelectedIndicatorColor = Color.FromRgba(20, 150, 250, 100),
            HorizontalOptions = LayoutOptions.Center,
            IndicatorColor = Colors.Transparent,
            Margin=new Thickness(0, 0, 0,50),
            //IndicatorsShape = IndicatorShape.Square,
            //IndicatorSize=20
            IndicatorTemplate=new DataTemplate(() => 
            { 
                Label l = new Label { 
                    Text = "\uf30c", 
                    FontSize = 30,
                    FontFamily="ionicons",
                    TextColor=Color.FromRgba(20,150,200,70)
                };
                return l;
            })
        };
        
        CarouselView carouselView = new CarouselView
        {
            VerticalOptions = LayoutOptions.Center,
            ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal),
            IndicatorView = indicatorView,
        };
        carouselView.ItemsSource = new List<Aine>
        {
            new Aine {Nimetus="Aine1",Kirjeldus="Kirjeldus1",Maht=100, Pilt="dotnet_bot.svg"},
            new Aine {Nimetus="Aine2",Kirjeldus="Kirjeldus2",Maht=200, Pilt="dotnet_bot.svg"},
            new Aine {Nimetus="Aine3",Kirjeldus="Kirjeldus3", Maht=50, Pilt="dotnet_bot.svg"},
            new Aine {Nimetus="Aine4",Kirjeldus="Kirjeldus4", Maht=250, Pilt="dotnet_bot.svg"},
            new Aine {Nimetus="Aine5",Kirjeldus="Kirjeldus5", Maht=50, Pilt="dotnet_bot.svg"},
        };
        carouselView.ItemTemplate = new DataTemplate(() =>
        {
            Label pealkiri = new Label
            {
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 18
            };
            pealkiri.SetBinding(Label.TextProperty, "Nimetus");
            Image pilt = new Image 
            { 
                WidthRequest = 150, 
                HeightRequest = 150 
            };
            pilt.SetBinding(Image.SourceProperty, "Pilt");
            Label kirjeldus = new Label 
            { 
                HorizontalTextAlignment = TextAlignment.Center 
            };
            kirjeldus.SetBinding(Label.TextProperty, "Kirjeldus");
            Slider maht = new Slider 
            { 
                Minimum = 0, 
                Maximum = 320 
            };
            maht.SetBinding(Slider.ValueProperty, "Maht");
            
            VerticalStackLayout vsl = new VerticalStackLayout() { pealkiri, pilt, kirjeldus, maht};
            frame = new Frame{ WidthRequest = 250, HeightRequest = 300 };
            frame.Content = vsl;

            return frame;
        });
        VerticalStackLayout v = new VerticalStackLayout() { carouselView, indicatorView };
        Content = v; //carouselView;

    }
}