namespace Invento.XamarinFormsIconCreator;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	private async void OnTapImageGestureRecognizerTapped(object sender, EventArgs e)
	{
        PickOptions options = new PickOptions
        {
            PickerTitle = "Select Image",
            FileTypes = FilePickerFileType.Images
        };
        var result = await FilePicker.Default.PickAsync(options);
        if (result != null)
        {
            if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
            {
                Stream stream = await result.OpenReadAsync();

                ImageFileObject.Source = ImageSource.FromStream(() => stream);
                ImageFileLabelObject.Text= result.FileName;
            }
        }
    }

    private async void CreatedClickedEventHandler(object sender, EventArgs e)
    {
        
    }

    private void OnXamarinFormsClickedEventHandler(object sender, EventArgs e)
    {
        XamarinFromsCheckboxObject.IsChecked = !XamarinFromsCheckboxObject.IsChecked;
    }
}