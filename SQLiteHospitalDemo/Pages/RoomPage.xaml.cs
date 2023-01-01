using SQLiteHospitalDemo.Models;

namespace SQLiteHospitalDemo;

public partial class RoomPage : ContentPage
{
	public RoomPage()
	{
		InitializeComponent();
        roomListView.ItemsSource = App.roomRepo.GetAll();
        doctorPicker.ItemsSource = App.doctorRepo.GetAll().Select(x => x.ID).ToArray();
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        roomListView.ItemsSource = App.roomRepo.GetAll();
        List<int> doctorRepoTemp = App.doctorRepo.GetAll().Select(x => x.ID).ToList();
        await Task.Delay(200);
        doctorPicker.ItemsSource = doctorRepoTemp;
    }

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (doctorPicker.SelectedItem != null)
            {
                App.roomRepo.Add(new Models.RoomModel
                {
                    DoctorID = Convert.ToInt32(doctorPicker.SelectedItem),
                    RoomNumber = Convert.ToInt32(roomNumberEntry.Text)
                });
                roomListView.ItemsSource = App.roomRepo.GetAll();
            }
            else DisplayAlert("Error", "You have to select doctor", "OK");
        }
        catch (Exception ex)
        {
            if(ex.Message.Contains("DoctorID")) DisplayAlert("Error", "The doctor already has one room\n" + ex.Message, "OK");
            else if(ex.Message.Contains("RoomNumber")) DisplayAlert("Error", "The room has already been taken\n" + ex.Message, "OK");
        }
        
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        RoomModel room = (RoomModel)button.BindingContext;
        App.roomRepo.Delete(room);
        roomListView.ItemsSource = App.roomRepo.GetAll();
    }
}