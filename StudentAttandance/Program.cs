using Microsoft.EntityFrameworkCore;
using StudentAttandance.Data;
using StudentAttandance.Data.Entity;
using StudentAttandance.Data.Managers;
using StudentAttandance.Helpers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddScoped<IDataRepository<Attendance>, AttendanceManager>();
builder.Services.AddScoped<IDataRepository<Complain>, ComplainManager>();
builder.Services.AddScoped<IDataRepository<Division>, DivisionManager>();
builder.Services.AddScoped<IDataRepository<Leave>, LeaveManager>();
builder.Services.AddScoped<IDataRepository<Staff>, StaffManager>();
builder.Services.AddScoped<IDataRepository<Standard>, StandardManager>();
builder.Services.AddScoped<IDataRepository<Student>, StudentManager>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(c => { c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); });

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();
app.MapControllers();
app.Run();
