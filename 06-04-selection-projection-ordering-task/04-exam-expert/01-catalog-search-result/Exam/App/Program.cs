using App;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("csarp_aaf_aaf2_linq_06_linq_backend_06_04_selection_projection_ordering_task_04_exam_expert_01_catalog_search_result_Exam"));
builder.Services.AddScoped<EfExpertCatalogTasks>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();