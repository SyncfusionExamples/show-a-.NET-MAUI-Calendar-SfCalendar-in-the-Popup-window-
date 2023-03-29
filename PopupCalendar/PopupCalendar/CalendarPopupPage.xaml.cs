using CommunityToolkit.Maui.Views;
using Syncfusion.Maui.Calendar;

namespace PopupCalendar;

public partial class CalendarPopupPage : Popup
{
	public CalendarPopupPage()
	{
		InitializeComponent();
	}

    private void SelectionModeButton_Clicked(object sender, EventArgs e)
    {
        if (this.calendar.SelectionMode == CalendarSelectionMode.Single)
        {
            this.calendar.SelectionMode = CalendarSelectionMode.Range;
            this.SelectionModeButton.Text = "Range";
        }
        else
        {
            this.calendar.SelectionMode = CalendarSelectionMode.Single;
            this.SelectionModeButton.Text = "Single";
        }
    }
}