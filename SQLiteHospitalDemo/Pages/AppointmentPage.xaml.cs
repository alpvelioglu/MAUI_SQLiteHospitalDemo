using SQLiteHospitalDemo.Models;
using System.Collections;

namespace SQLiteHospitalDemo;

public partial class AppointmentPage : ContentPage
{
	public AppointmentPage()
	{
		InitializeComponent();
        appointmentListView.ItemsSource = App.appointmentRepo.GetAll();
        patientPicker.ItemsSource = App.patientRepo.GetAll().Select(x => x.ID).ToArray();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        appointmentListView.ItemsSource = App.appointmentRepo.GetAll();
        List<int> patientRepoTemp = App.patientRepo.GetAll().Select(x => x.ID).ToList();
        await Task.Delay(200);
        patientPicker.ItemsSource = patientRepoTemp as IList;
    }

    //protected override void OnDisappearing()
    //{
    //    base.OnDisappearing();
    //    appointmentListView.ItemsSource = App.appointmentRepo.GetAll();
    //    List<int> patientRepoTemp = App.patientRepo.GetAll().Select(x => x.ID).ToList();
    //    patientPicker.ItemsSource = patientRepoTemp;
    //    patientPicker.ItemsSource = patientPicker.GetItemsAsList();
    //}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        if (patientPicker.SelectedItem != null)
        {
            App.appointmentRepo.Add(new Models.AppointmentModel
            {
                PatientID = Convert.ToInt32(patientPicker.SelectedItem),
                Appoint_Date = appointmentDate.Date,
                Appoint_Reason = editor_reason.Text
            });
            appointmentListView.ItemsSource = App.appointmentRepo.GetAll();
        }
        else DisplayAlert("Error", "You have to select patient", "OK");
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        AppointmentModel appointment = (AppointmentModel)button.BindingContext;
        App.appointmentRepo.Delete(appointment);
        appointmentListView.ItemsSource = App.appointmentRepo.GetAll();
    }
}