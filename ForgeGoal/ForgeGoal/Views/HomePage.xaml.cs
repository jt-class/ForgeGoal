using System.Diagnostics;

namespace ForgeGoal.Views;

public partial class HomePage : ContentPage
{
	private bool isHidden = true;
	private bool isHidden2 = true;
	private bool isInvite = false;
	public HomePage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
		HideControls1();
		HideControls2();
    }
	private void OnHamburgerClicked(object sender, EventArgs e)
	{
        Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
    }

	private async void OnCalendarTapped(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//CalendarPage");
    }
	private async void OnUpdatesTapped(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//UpdatesPage");
    }
	private void OnAddClicked(object sender, EventArgs e)
	{
        if (isHidden)
		{
            ShowControls1();
			AddButton.FontSize = 30;
        } else
		{
			HideControls1();
			AddButton.Text = "+";
			AddButton.FontSize = 45;
		}	
	}
	private void OnInviteClicked(object sender, EventArgs e)
	{
		ShowControls2();
		isInvite = true;
		CreateLabel.Text = "Insert Invite Code";
		ProjectEntry.Placeholder = "Invite Code";
		JoinCreateButton.Text = "Join";
	}
	private void OnCreateClicked(object sender, EventArgs e)
	{
		isInvite = false;
		ShowControls2();
        CreateLabel.Text = "Create New Project";
        ProjectEntry.Placeholder = "Project Name";
        JoinCreateButton.Text = "Create";
    }
	private void OnCloseClicked(object sender, EventArgs e)
	{
		HideControls2();
		isHidden2 = true;
	}
	private void HideControls1()
	{
		BlackFrame.IsVisible = false;
		MailButton.IsVisible = false;
		InviteLabel.IsVisible = false;
		ProjectButton.IsVisible = false;
		ProjectLabel.IsVisible = false;
		isHidden = true;
	}
	private void ShowControls1()
	{
        BlackFrame.IsVisible = true;
        MailButton.IsVisible = true;
        InviteLabel.IsVisible = true;
        ProjectButton.IsVisible = true;
        ProjectLabel.IsVisible = true;
		AddButton.Text = "x";
		isHidden = false;
    }

	private void HideControls2()
	{
		BlackFrame2.IsVisible = false;
		Frame2.IsVisible = false;
		CreateLabel.IsVisible = false;
		CloseWindowButton.IsVisible = false;
		ProjectEntry.IsVisible = false;
		EntryLine.IsVisible = false;
		JoinCreateButton.IsVisible = false;
	}
	private void ShowControls2()
	{
        BlackFrame2.IsVisible = true;
        Frame2.IsVisible = true;
        CreateLabel.IsVisible = true;
        CloseWindowButton.IsVisible = true;
        ProjectEntry.IsVisible = true;
        EntryLine.IsVisible = true;
        JoinCreateButton.IsVisible = true;
		isHidden2 = false;
    }
}