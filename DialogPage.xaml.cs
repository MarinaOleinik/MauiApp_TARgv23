
using Microsoft.Maui.Controls.Shapes;

namespace MauiApp_TARgv23;

public partial class DialogPage : ContentPage
{
    Random rnd= new Random();
    
	public DialogPage()
	{   

        Button alertButton = new Button
        {
            Text = "Teade",
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Center,
            WidthRequest= 200,
            HeightRequest= 150,
            BorderWidth=10,
            BorderColor= Colors.BlueViolet,
            FontFamily = "Socafe 400"
        };
        alertButton.Clicked += AlertButton_Clicked;
        Button alertYesNoButton = new Button
        {
            Text = "Jah või ei",
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Center,
            WidthRequest = 200,
            HeightRequest = 150,
            BorderWidth = 10,
            BorderColor = Colors.BlueViolet,
            FontFamily = "Socafe 400"
        };
        alertYesNoButton.Clicked += AlertYesNoButton_Clicked;
        Button alertListButton = new Button
        {
            Text = "Valik loeteust",
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Center,
            WidthRequest = 200,
            HeightRequest = 150,
            BorderWidth = 10,
            BorderColor = Colors.BlueViolet,
            FontFamily = "Socafe 400"
        };
        alertListButton.Clicked += AlertListButton_Clicked; 
        Button alertQuestButton = new Button
        {
            Text = "Küsimus",
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Center,
            WidthRequest = 200,
            HeightRequest = 150,
            BorderWidth = 10,
            BorderColor = Colors.BlueViolet,
            FontFamily = "Socafe 400"
        };
        alertQuestButton.Clicked += AlertQuestButton_Clicked;
        Content = new StackLayout { Children = { alertButton, alertYesNoButton, alertListButton, alertQuestButton }};
    }
    //Lihne teade
    private void AlertButton_Clicked(object? sender, EventArgs e)
    {
        DisplayAlert("Teade", "Teil on uus teade", "ОK");
    }
    //Valikuga
    private async void AlertYesNoButton_Clicked(object? sender, EventArgs e)
    {
        bool result = await DisplayAlert("Kinnitus", "Kas oled kindel?", "Olen kindel", "Ei ole kindel");
        await DisplayAlert("Teade", "Teie valik on: " + (result ? "Jah" : "Ei"), "OK");
    }
    //Valikvastusega
    private async void AlertQuestButton_Clicked(object? sender, EventArgs e)
    {
        int a = rnd.Next(0, 10);
        int b = rnd.Next(0, 10);
        string result1 = await DisplayPromptAsync("Küsimus", "Kuidas läheb?", placeholder: "Tore!");
        string result2 = await DisplayPromptAsync("Vasta", $"Millega võrdub {a} + {b}?", initialValue: (a + b).ToString(), maxLength: 2, keyboard: Keyboard.Numeric);//saavad olla veel Text, Url, Chat, Date, Default, Email, Password,Telephone
        if (result2 == (a + b).ToString())
        {
            await DisplayAlert("Tulemus", "Õige vastus!", "Ok");
        }
        else
        {
            await DisplayAlert("Tulemus", "Vale vastus!", "Ok");
        }
    }
    //Valik järjendist
    private async void AlertListButton_Clicked(object? sender, EventArgs e)
    {
        var action = await DisplayActionSheet("Mida tahad teha?", "Loobu", "Ok", "Tantsida", "Laulda", "Värvida");
        var teade="";
        if (action=="Tantsida")
        {
            teade = "Kaks sammu sissepoole\nKaks sammu väljapoole\nplaks ja parem käsi\nplaks ja vasak käsi\nVahetus!";
        }
        else if (action=="Laulda")
        {
            teade = "Jänku hüppab üles-üles\nTundub, et on heas ta tujus\nKüsin jänkult “Mis sa teed?”\nTema aga hüppab veel.";
        }
        else if(action=="Värvida")
        {
            teade= await DisplayActionSheet("Vali värv?", "Loobu", "Kustutada", "Sinine", "Must", "Valge");
        }
        else 
        {
            //kirjuta ise
            teade = "Oli vaja midagi valida";
        }
        await DisplayAlert(action, teade, "Ok","Loobu");
    }
}