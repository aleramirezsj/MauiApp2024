namespace PrimeraMauiApp.Pages;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new LibrosPage());
    }
}