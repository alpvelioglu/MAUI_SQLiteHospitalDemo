using SQLiteHospitalDemo.Models;

namespace SQLiteHospitalDemo;

public partial class PatientPage : ContentPage
{
    PatientModel p;
	public PatientPage()
	{
		InitializeComponent();
		patientListView.ItemsSource = App.patientRepo.GetAll();
	}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        if(p != null && p.ID != 0)
        {
            App.patientRepo.Add(new Models.PatientModel
            {
                ID = p.ID,
                PatientName = patientNameEntry.Text,
                PatientLastName = patientLastNameEntry.Text
            });
            patientListView.ItemsSource = App.patientRepo.GetAll();
        }
        else
        {
            App.patientRepo.Add(new Models.PatientModel
            {
                PatientName = patientNameEntry.Text,
                PatientLastName = patientLastNameEntry.Text
            });
            patientListView.ItemsSource = App.patientRepo.GetAll();
        }
        p = null;
        AddButton.Text = "Add";
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        PatientModel patient = (PatientModel)button.BindingContext;
        App.patientRepo.Delete(patient);
        patientListView.ItemsSource = App.patientRepo.GetAll();
    }

    private void patientListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        p = (PatientModel)e.Item;
        patientNameEntry.Text = p.PatientName.ToString();
        patientLastNameEntry.Text = p.PatientLastName.ToString();
        AddButton.Text = "Update";
    }
}