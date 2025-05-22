using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tickets.Infrastructure.Context;
using Tickets.Infrastructure.Repository;
using Tickets.Infrastructure.Repository.Interfaces;
using Tickets.Application.Mapping;
using Ticket.Application.Mapping;
using Tickets.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<TicketsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddScoped<IAdvertiserRepository, AdvertiserRepository>();
builder.Services.AddScoped<IBuyerRepository,BuyerRepository>();
builder.Services.AddScoped<IEventRepository,EventRepository>();
builder.Services.AddScoped<Mapping>();
builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
