namespace maui_drawingview_repro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();

		Loaded += (_, __) => OnShowImageClicked(ShowImageBtn, EventArgs.Empty);
	}

	private async void OnShowImageClicked(object sender, EventArgs e)
	{
		var s = await drawingView.GetImageStream(250, 250);
        imageResult.Source = ImageSource.FromStream(() => s);
	}
}

