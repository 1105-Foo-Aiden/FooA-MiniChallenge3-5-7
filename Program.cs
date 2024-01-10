using FooA_MiniChallenge3_5_7.Services.MadLib;
using FooA_MiniChallenge3_5_7.Services.OddEven;
using FooA_MiniChallenge3_5_7.Services.ReverseNum;
using FooA_MiniChallenge3_5_7.Services.ReverseWord;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOddEven, OddEven>();
builder.Services.AddScoped<IMadLib, MadLib>();
builder.Services.AddScoped<IReverseNum, ReverseNum>();
builder.Services.AddScoped<IReverseWord, ReverseWord>();

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
