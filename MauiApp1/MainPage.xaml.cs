namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        List<string> list = new List<string>() { "Apple", "Banana", "Orange", "Guava", "Peach", "Melon" }; 
        public MainPage()
        {
            InitializeComponent();
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new Page2(txtName.Text));
        //}

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            DisplayAlert("Selected", e.SelectedItem.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}