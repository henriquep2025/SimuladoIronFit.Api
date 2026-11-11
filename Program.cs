using Microsoft.EntityFrameworkCore;
using SimuladoIronFit.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Add CORS
// Adicionar suporte a CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();


/*
 using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SimuladoIronFit.Api.Data; // Ajuste para o namespace correto do seu contexto
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// 1. Adicionar o DbContext (Banco de Dados)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<IronFitDbContext>(options => 
    options.UseSqlServer(connectionString)
);

// 2. Adicionar Autenticação JWT Bearer
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("chaveSuperSecretaIronFitProjeto2026!@#")
            )
        };
    });

// 3. Configurar o Swagger para suportar o Token JWT na interface
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Insira o token JWT desta maneira: Bearer {seu_token}",
    });
    
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

// 4. Configurações de Controllers e CORS
builder.Services.AddControllers();
builder.Services.AddCors(options => options.AddPolicy("PermitirTudo", policy =>
{
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader();
}));

var app = builder.Build();

// 5. Configurar o Pipeline de Requisições HTTP (Middlewares)

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("PermitirTudo");

// ATENÇÃO: UseAuthentication deve vir SEMPRE antes do UseAuthorization
app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllers();

app.Run();
 */