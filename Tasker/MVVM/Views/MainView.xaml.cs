using Tasker.MVVM.ViewModels;

namespace Tasker.MVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel ViewModel = new MainViewModel();
	public MainView()
	{
		InitializeComponent();
		BindingContext = ViewModel;
    }
    private void ckbCompleted_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ViewModel.UpdateData();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var taskview = new NewTaskView
        {
            BindingContext = new NewTaskViewModel
            {
                Tasks = ViewModel.Tasks,
                Categories = ViewModel.Categories
            }

        };
        Navigation.PushAsync(taskview);
    }
}