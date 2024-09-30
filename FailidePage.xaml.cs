namespace MauiApp_TARgv23;

public partial class FailidePage : ContentPage
{
	public FailidePage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        UpdateFileList();
    }
    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
    private async void Button_Clicked(object sender, EventArgs e)
    {
		string filename= FileNameEntry.Text;
        if (String.IsNullOrEmpty(filename)) { return; }
		if(File.Exists(Path.Combine(folderPath,filename))) 
		{
			bool isRewrited = await DisplayAlert("Fail on juba olemas", "Kas tahad ümberkirjutada?", "jah", "ei");
			if (isRewrited==false) { return; }
		}
		File.WriteAllText(Path.Combine(folderPath,filename),TextEditor.Text);
        UpdateFileList();
    }
    private void FilesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null) { return; }
        string filename=FilesList.SelectedItem.ToString();
        TextEditor.Text = File.ReadAllText(Path.Combine(folderPath,filename));
        FileNameEntry.Text = filename;
        FilesList.SelectedItem = null;
    }
    private void UpdateFileList() 
    {
        FilesList.ItemsSource=Directory.GetFiles(folderPath).Select(f=>Path.GetFileName(f)).ToList();
        FilesList.SelectedItem=null;
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        string filename=(string)((MenuItem)sender).BindingContext;
        File.Delete(Path.Combine(folderPath,filename));
        UpdateFileList();
    }

    private void LoList_Clicked(object sender, EventArgs e)
    {
        string filename = (string)((MenuItem)sender).BindingContext;
        List<string> list = File.ReadLines(Path.Combine(folderPath,filename)).ToList();
        ListFailist.ItemsSource=list;
    }
}