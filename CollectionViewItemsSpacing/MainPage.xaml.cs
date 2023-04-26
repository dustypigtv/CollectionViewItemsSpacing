using System.Collections.ObjectModel;

namespace CollectionViewItemsSpacing;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        Items = new ObservableCollection<string>
        {
            "https://api.time.com/wp-content/uploads/2022/01/TIM220117_Shonda.Cover_.FINALv2.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/01/TIM220131_Biden.Cover_.FINAL_.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/02/TIM220214_Covid.Cover_.FINAL_.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/02/TIM220228_KOTY.Cover_.FINAL_.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/03/TIM220314-Amal-Clooney-Cover-women-of-the-year.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/03/TIM220411-Kaling-Cover.FINAL_.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/04/TIM220425-Ohtani-Cover.FINAL2_.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/04/Musk.Cover_.Final_.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/05/TIM220523_Arctic-Cover-FINAL.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/05/TIM220606_Zendaya-Cover.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/05/Enough.Cover_.Final_.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/06/TIM220704_OceansCover.FINAL_.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/07/TIM220725_WGP-Cover-Final.jpg?quality=85&w=840",
            "https://api.time.com/wp-content/uploads/2022/06/TIM220725_Abortion-Cover.jpg?quality=85&w=840"
        };

        BindingContext = this;
	}

    public ObservableCollection<string> Items { get; }

}
