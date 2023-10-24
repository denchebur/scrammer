using BLL.Interfaces;
using BLL.Services;
using DAL;
using DAL.Repository;
using DAL.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureServices(builder.Configuration);

builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


// бля я тут запишу шоб не забыть
// надо кароче уебать шоб можно было делиться доской с типами и там был типо
// как ссылка уникальная, настройки приватности я хз, думаю там будет доступ только по ссылке, никаких поисков, ну или будет шото типа аййдишника хз