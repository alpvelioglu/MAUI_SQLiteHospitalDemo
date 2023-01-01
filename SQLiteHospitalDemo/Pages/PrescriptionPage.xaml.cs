using SQLiteHospitalDemo.Models;

namespace SQLiteHospitalDemo;

public partial class PrescriptionPage : ContentPage
{
    PatientModel patient;
    DoctorModel doctor;
    PrescriptionModel prescriptionToDelete;

	public PrescriptionPage()
	{
		InitializeComponent();
		patientListView.ItemsSource = App.patientRepo.GetAll();
		doctorListView.ItemsSource = App.doctorRepo.GetAll();
        prescriptionListView.ItemsSource = App.prescriptionRepo.GetAll();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        patientListView.ItemsSource = App.patientRepo.GetAll();
        doctorListView.ItemsSource = App.doctorRepo.GetAll();
        prescriptionListView.ItemsSource = App.prescriptionRepo.GetAll();
    }

    private void doctorListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        doctor = (DoctorModel)e.Item;
    }

    private void patientListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        patient = (PatientModel)e.Item;
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        prescriptionToDelete = (PrescriptionModel)button.BindingContext;
        App.prescriptionRepo.Delete(prescriptionToDelete);
        prescriptionListView.ItemsSource = App.prescriptionRepo.GetAll();
    }

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        if (doctor != null && patient != null)
        {
            App.prescriptionRepo.Add(new Models.PrescriptionModel
            {
                DoctorID = doctor.ID,
                DoctorName = doctor.DoctorName,
                PatientID = patient.ID,
                PatientName = patient.PatientName,
                Prescription_Date = datePickerPres.Date,
                Prescription_List = prescriptionListEntry.Text
            });
            prescriptionListView.ItemsSource = App.prescriptionRepo.GetAll();
        }
        else DisplayAlert("Error", "You have to select doctor and student from above list", "OK");
        
    }
}