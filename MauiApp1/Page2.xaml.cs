namespace MauiApp1;

public partial class Page2 : ContentPage
{
	public Page2(string uName)
	{
		InitializeComponent();
        lblUserName.Text = uName;
	}
	//private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	//{
	//	Navigation.PopModalAsync();
	//}
}