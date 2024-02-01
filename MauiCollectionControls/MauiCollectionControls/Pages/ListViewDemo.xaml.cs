using MauiCollectionControls.Models;

namespace MauiCollectionControls.Pages;

public partial class ListViewDemo : ContentPage
{
    public ListViewDemo()
    {
        InitializeComponent();

        var Items = new List<CollectionItems>
        {
            new CollectionItems { Title = "Ad�", Description = "H�seyin" },
		    new CollectionItems { Title = "Soyad�", Description = "Ta�demir" },
		    new CollectionItems { Title = "�ehir", Description = "�zmir" },
			new CollectionItems { Title = "�l�e", Description = "Bornova" },
		
		};

        listView.ItemsSource = Items;
    }
}