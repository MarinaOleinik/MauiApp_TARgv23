using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp_TARgv23
{
    public class CreatePage: ContentPage
    {
        public List<string> buttons = new List<string> { "Tagasi", "Avaleht", "Edasi" };
        int k;
        public List<string> nimetused = new List<string> { "TextPage", "FigurePage" };
        public CreatePage(List<string> buttons, int k )
        {
            this.buttons = buttons;
            this.k = k;
            
        }
        /*public static class App
{
    static readonly StackLayout stackLayout = new StackLayout {
        BackgroundColor = Color.Gray,
        VerticalOptions = LayoutOptions.Start,
        Spacing = 2,
        Padding = 2,
    };

    public static Page GetMainPage()
    {
        AddButton("Start", LayoutOptions.Start);
        AddButton("Center", LayoutOptions.Center);
        AddButton("End", LayoutOptions.End);
        AddButton("Fill", LayoutOptions.Fill);
        AddButton("StartAndExpand", LayoutOptions.StartAndExpand);
        AddButton("CenterAndExpand", LayoutOptions.CenterAndExpand);
        AddButton("EndAndExpand", LayoutOptions.EndAndExpand);
        AddButton("FillAndExpand", LayoutOptions.FillAndExpand);

        return new NavigationPage(new ContentPage {
            Content = stackLayout,
        });
    }

    static void AddButton(string text, LayoutOptions verticalOptions)
    {
        stackLayout.Children.Add(new Button {
            Text = text,
            BackgroundColor = Color.White,
            VerticalOptions = verticalOptions,
            HeightRequest = 20,
            Command = new Command(() => {
                stackLayout.VerticalOptions = verticalOptions;
                (stackLayout.ParentView as Page).Title = "StackLayout: " + text;
            }),
        });
        stackLayout.Children.Add(new BoxView {
            HeightRequest = 1,
            Color = Color.Yellow,
        });
    }
}*/
    }
}
