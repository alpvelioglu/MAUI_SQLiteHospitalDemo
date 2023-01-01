using SQLiteHospitalDemo.Abstract;
using SQLiteHospitalDemo.Models;

namespace SQLiteHospitalDemo;

public partial class App : Application
{
	public static BaseRepository<PatientModel> patientRepo;
	public static BaseRepository<DoctorModel> doctorRepo;
	public static BaseRepository<PrescriptionModel> prescriptionRepo;
	public static BaseRepository<AppointmentModel> appointmentRepo;
	public static BaseRepository<RoomModel> roomRepo;

	public App(BaseRepository<PatientModel> patient,
               BaseRepository<DoctorModel> doctor,
               BaseRepository<PrescriptionModel> prescription,
               BaseRepository<AppointmentModel> appointment,
               BaseRepository<RoomModel> room)
	{
		InitializeComponent();
		patientRepo = patient;
		doctorRepo = doctor;
		prescriptionRepo = prescription;
		appointmentRepo = appointment;
		roomRepo = room;
		MainPage = new AppShell();
	}
}
