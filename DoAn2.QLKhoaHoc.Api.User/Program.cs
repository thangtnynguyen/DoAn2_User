using BUS.Interfaces;
using BUS;
using DAO.Helper.Interfaces;
using DAO.Helper;
using DAO.Interfaces;
using DAO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ITruyVanDuLieu, TruyVanDuLieu>();
builder.Services.AddTransient<IKhoaHocDAO, KhoaHocDAO>();
builder.Services.AddTransient<ILoaiKhoaHocDAO, LoaiKhoaHocDAO>();
builder.Services.AddTransient<IKhoaHocBUS, KhoaHocBUS>();
builder.Services.AddTransient<ILoaiKhoaHocBUS, LoaiKhoaHocBUS>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(
    x => x.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
