using SkiaSharp.Views.Maui.Controls.Hosting;
using SQLiteHospitalDemo.Abstract;
using SQLiteHospitalDemo.Models;

namespace SQLiteHospitalDemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<BaseRepository<PatientModel>>();
		builder.Services.AddSingleton<BaseRepository<DoctorModel>>();
		builder.Services.AddSingleton<BaseRepository<AppointmentModel>>();
		builder.Services.AddSingleton<BaseRepository<RoomModel>>();
		builder.Services.AddSingleton<BaseRepository<PrescriptionModel>>();
		return builder.Build();
	}
}
