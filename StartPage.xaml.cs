namespace MauiApp_TARgv23;

public partial class StartPage : ContentPage
{
	public List<ContentPage> lehed=new List<ContentPage>() { new TextPage(0), new FigurePage(1), new DateTimePage(2), new SliderStepperPage(3), new RGB_mudel(4), new PickerImagePage(5),new DialogPage(),new TablePage() , new FailidePage()};
	public List<string> tekstid = new List<string> { "Tee lahti TextPage", "Tee lahti FigurePage","Tee lahti DateTimePage", "Tee lahti SliderStepperPage", "RGB mudeli leht" , "Leht piltidega","Ava dialoog aknad","Ava tabel", "Töö failidega"};
	Image img;
    ScrollView sv;
	VerticalStackLayout vst;
	public StartPage()
	{
		//InitializeComponent();
		
		Title = "Avaleht";
		vst = new VerticalStackLayout { BackgroundColor = Color.FromRgb(100, 50, 120) };
	

        img = new Image
		{
			Source = "start.png"
		};
        vst.Add(img);

        for (int i = 0; i < tekstid.Count; i++)
		{
			Button nupp = new Button
			{
				Text = tekstid[i],
				BackgroundColor = Color.FromRgb(20, 160, 100),
				TextColor = Color.FromRgb(10, 20, 15),
				FontFamily = "Socafe 400",
				BorderWidth = 10,
				ZIndex = i
			};
			vst.Add(nupp);
            nupp.Clicked += Nupp_Clicked;
		}
		sv = new ScrollView { Content = vst };
		Content = sv;
	}
    private async void Nupp_Clicked(object? sender, EventArgs e)
    {
        Button btn = sender as Button;
		await Navigation.PushAsync(lehed[btn.ZIndex]);
		
    }
}