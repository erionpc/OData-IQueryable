using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Batch;
using Microsoft.EntityFrameworkCore;
using OData_IQ_API.Abstractions.Data;
using OData_IQ_API.DbContexts;
using OData_IQ_API.EntityDataModels;
using OData_IQ_API.Repositories;

var builder = WebApplication.CreateBuilder(args);

var batchHandler = new DefaultODataBatchHandler();
batchHandler.MessageQuotas.MaxNestingDepth = 3;
batchHandler.MessageQuotas.MaxOperationsPerChangeset = 10;

builder.Services.AddControllers()
                .AddOData(opt =>
                    opt.AddRouteComponents("odata-dto",
                        new RecordStoreDtoEntityDataModel().GetEntityDataModel(),
                        batchHandler)
                    .Select()
                    .Expand()
                    .OrderBy()
                    .SetMaxTop(100)
                    .Count()
                    .Filter())
                .AddOData(opt =>
                    opt.AddRouteComponents("odata",
                        new RecordStoreEntityDataModel().GetEntityDataModel(),
                        batchHandler)
                    .Select()
                    .Expand()
                    .OrderBy()
                    .SetMaxTop(100)
                    .Count()
                    .Filter());

builder.Services.AddDbContext<RecordStoreDbContext>(options =>
{
    options.UseSqlServer(
        @"Server=(localdb)\mssqllocaldb;Database=RecordStoreDB;Trusted_Connection=True;")
    .EnableSensitiveDataLogging();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPeopleRepository, PeopleRepository>();

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
