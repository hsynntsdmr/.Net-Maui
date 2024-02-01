using MauiCollectionControls.Models;

namespace MauiCollectionControls.Pages;

public partial class ListViewDemo : ContentPage
{
    public ListViewDemo()
    {
        InitializeComponent();

        var Items = new List<CollectionItems>
        {
            new CollectionItems { Title = "Adý", Description = "Hüseyin" },
		    new CollectionItems { Title = "Soyadý", Description = "Taþdemir" },
		    new CollectionItems { Title = "Þehir", Description = "Ýzmir" },
			new CollectionItems { Title = "Ýlçe", Description = "Bornova" },
		
		};

        listView.ItemsSource = Items;
    }
}