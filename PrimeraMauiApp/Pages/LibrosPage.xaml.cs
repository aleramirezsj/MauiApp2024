using PrimeraMauiApp.Models;
using PrimeraMauiApp.Repositories;
using System.Collections.ObjectModel;

namespace PrimeraMauiApp.Pages;

public partial class LibrosPage : ContentPage
{
	Libro libroSeleccionado;
	LibrosRepository librosRepository=new LibrosRepository();
    ObservableCollection<Libro>? libros=new ObservableCollection<Libro>();

	public LibrosPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        libros = await librosRepository.ObtenerLibrosAsync();
        CollectionLibros.ItemsSource = libros;
    }

    private void btnVolver_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}