using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using On_Demand_Car_Wash.Context;
using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Repository;
using On_Demand_Car_Wash.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//adding cors 
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

//adding dbcontext 
builder.Services.AddDbContext<CarDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));
});



builder.Services.AddScoped<IUserDetail, UserDetailRepository>();
builder.Services.AddScoped<UserDetailService, UserDetailService>();

builder.Services.AddScoped<IOrderSendingData, OrderSendingDataRepository>();
builder.Services.AddScoped<OrderSendingDataService, OrderSendingDataService>();

builder.Services.AddScoped<ICar, CarRepository>();
builder.Services.AddScoped<CarService, CarService>();

builder.Services.AddScoped<IPackage, PackageRepository>();
builder.Services.AddScoped<PackageService, PackageService>();

builder.Services.AddScoped<IInvoice, InvoiceRepository>();
builder.Services.AddScoped<InvoiceService, InvoiceService>();

builder.Services.AddScoped<IAddress, AddressRepository>();
builder.Services.AddScoped<AddressService, AddressService>();

builder.Services.AddScoped<IOrder, OrderRepository>();
builder.Services.AddScoped<OrderService, OrderService>();


builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is the secret key we will use to generate token for the project")),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero   // to change default time 5 minute
    };

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
