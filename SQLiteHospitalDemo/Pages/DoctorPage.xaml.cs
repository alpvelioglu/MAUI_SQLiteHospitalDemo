using SQLiteHospitalDemo.Models;

namespace SQLiteHospitalDemo;

public partial class DoctorPage : ContentPage
{
	public DoctorPage()
	{
		InitializeComponent();
        doctorListView.ItemsSource = App.doctorRepo.GetAll();
	}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        App.doctorRepo.Add(new Models.DoctorModel
        {
            DoctorName = doctorNameEntry.Text,
            DoctorLastName = doctorLastNameEntry.Text
        });
        doctorListView.ItemsSource = App.doctorRepo.GetAll();
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        DoctorModel doctor = (DoctorModel)button.BindingContext;
        App.doctorRepo.Delete(doctor);
        doctorListView.ItemsSource = App.doctorRepo.GetAll();
    }
}