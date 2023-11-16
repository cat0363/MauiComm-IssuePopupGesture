using CommunityToolkit.Maui.Views;
namespace MauiComm_IssuePopupGesture;

public partial class PopupPage1 : Popup
{
	int tapTimes;

	public PopupPage1()
	{
		InitializeComponent();
	}

	void btnChangeSize_Clicked(object sender, EventArgs e)
	{
        gdTest.HeightRequest = 250;
    }

    void btnClick_Clicked(object sender, EventArgs e)
	{
		lblTapTimes.Text = "Tap Times : " + (++tapTimes);
	}

    void gdTest_SizeChanged(object sender, EventArgs e)
    {
        Size = new Size(Size.Width, gdTest.Height);
        // (Content!.Parent as VisualElement)!.HeightRequest = gdTest.Height;  // <= Workaround
    }
}