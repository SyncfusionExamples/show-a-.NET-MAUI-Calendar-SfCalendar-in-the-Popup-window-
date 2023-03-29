using CommunityToolkit.Maui.Views;

namespace PopupCalendar;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void CalendarButton_Clicked(object sender, EventArgs e)
    {
		this.ShowPopup(new CalendarPopupPage());
    }
}

