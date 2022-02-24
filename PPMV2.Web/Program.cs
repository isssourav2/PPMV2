using Microsoft.EntityFrameworkCore;
using PPMV2.Core.Infrastructure.ApplicationRepo;
using PPMV2.Core.Infrastructure.ConnectionRepo;
using PPMV2.Core.Infrastructure.EmailSettingRepo;
using PPMV2.Core.Infrastructure.FileProcessingTemplateFormulaFieldRepo;
using PPMV2.Core.Infrastructure.FileProcessingTemplateRepo;
using PPMV2.Core.Infrastructure.FileReadingIndentification;
using PPMV2.Core.Infrastructure.FileValid;
using PPMV2.Core.Infrastructure.MenuRepo;
using PPMV2.Core.Infrastructure.MenuwithRoleRepo;
using PPMV2.Core.Infrastructure.Repository;
using PPMV2.Core.Infrastructure.RiskCoreTemplates;
using PPMV2.Core.Infrastructure.RoleRepo;
using PPMV2.Core.Infrastructure.SchedulerSettingRepo;
using PPMV2.Core.Infrastructure.SourceRepo;
using PPMV2.Core.Infrastructure.TagRepo;
using PPMV2.Core.Infrastructure.UserRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ITagRepository, TagRepository>();
builder.Services.AddTransient<IRoleRepository, RoleRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<IApplicationRepository, ApplicationRepository>();
builder.Services.AddTransient<IMenuwithRoleRepository, MenuwithRoleRepository>();
builder.Services.AddTransient<ISourceRepository, SourceRepository>();
builder.Services.AddTransient<IEmailSettingRepository, EmailSettingRepository>();
builder.Services.AddTransient<ISchedulerSettingRepository, SchedulerSettingRepository>();
builder.Services.AddTransient<IConnectionRepository, ConnectionRepository>();
builder.Services.AddTransient<IRiskCoreTemplateRepository, RiskCoreTemplateRepository>();
builder.Services.AddTransient<IFileProcessingTemplate, FileProcessingTemplate>();
builder.Services.AddTransient<IFileReadRepository, FileReadRepository>();
builder.Services.AddTransient<IFileValidationRepository, FileValidationRepository>();
builder.Services.AddTransient<IFileProcessingTemplateFormulaFieldRepository, FileProcessingTemplateFormulaFieldRepository>();
var app = builder.Build();
//database migration


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}
app.UseCors(x => x.AllowAnyHeader()
      .AllowAnyMethod()
      .AllowAnyOrigin());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
