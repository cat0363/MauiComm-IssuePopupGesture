using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupGesture;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void btnTest1_Clicked(object sender, EventArgs e)
	{
		var popup = new PopupPage1();
		Shell.Current.CurrentPage.ShowPopup(popup);		
    }
}

