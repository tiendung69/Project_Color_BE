using Color_Media.Models;
using Color_Media.Service.Implements;
using Color_Media.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
IServiceCollection services = builder.Services;
IdentityModelEventSource.ShowPII = true;
services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    x.JsonSerializerOptions.PropertyNamingPolicy = null;
    x.JsonSerializerOptions.WriteIndented = true;
}).AddOData(options => options.Select().Filter().OrderBy().Expand().EnableQueryFeatures().AddRouteComponents(GetEdmModel()));
string connectionString = builder.Configuration["ConnectionStrings:value"];
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Limits.MaxRequestBodySize = int.MaxValue;
});
builder.Services.AddDbContext<thnd_qlsx_phimContext>(options =>
{
    options.UseSqlServer(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

services.AddRouting();
services.AddTransient<IBroadcastingService, BroadCastingService>();
services.AddTransient<IBroadCastingDocumentService, BroadcastingDocumentService>();
services.AddTransient<IAuthenticationService, AuthenticationService>();
services.AddTransient<IEstimateService, EstimateService>();
services.AddTransient<ICommoncategoryService, CommoncategoryService>();
services.AddTransient<IApprovedService, ApprovedService>();
services.AddTransient<IMovieApprovalService, MovieApprovalService>();
services.AddTransient<IMovieApprovalDetailService, MovieApprovalDetailService>();
services.AddTransient<IPostProductionPlaningService, PostproductionPlaningService>();
services.AddTransient<IPostProductionPlaningProgressService, PostproductionProgressService>();
services.AddTransient<IPostProductionProgressMemberService, PostproductionPogressMemberService>();
services.AddTransient<IPreproductionExpenseService, PreproductionExpenseService>();
services.AddTransient<IPreproductionMemberService, PreproductionMemberService>();
services.AddTransient<IPreproductionPlaningService, PreproductionPlaningService>();
services.AddTransient<IPreproductionProgressService, PreproductionProgressService>();
services.AddTransient<IPreproductionProgressMemberService, PreproductionProgressMemberService>();
services.AddTransient<IPreproductionSegmentService, PreproductionSegmentService>();
services.AddTransient<IPreproductionSegmentMemberService, PreproductionSegmentMemberService>();
services.AddTransient<ITeamService, TeamService>();
services.AddTransient<ITeamMemberService, TeamMemberService>();
services.AddTransient<ITopicService, TopicService>();
services.AddTransient<ITopicDocumentService, TopicDocumentService>();
services.AddTransient<ITopicMemberService, TopicMemberService>();
services.AddTransient<IUserService, UserService>();
services.AddTransient<IUserRightService, UserRightService>();
services.AddTransient<IVideoService, VideoService>();
services.AddTransient<IUserRoleService, UserRoleService>();
// Add services to the container.
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mirror API", Version = "v1", Description = "Version: 1.0.0" });
    //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    //c.IncludeXmlComments(xmlPath);
});
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");
    c.RoutePrefix = "DocumentAPI";

});
app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
IEdmModel GetEdmModel()
{
    var odataBuilder = new ODataConventionModelBuilder();
    odataBuilder.EntitySet<Broadcasting>("BroadCastings").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Broadcastingdocument>("BroadCastingDocument").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Estimate>("Estimate").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<VCommoncategory>("VCommoncategories").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Commoncategory>("Commoncategories").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Audit>("Audits").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Approved>("Approveds").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Mappingfield>("Mappingfields").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Mappingtable>("Mappingtables").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Movieapproval>("Movieapprovals").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<MovieapprovalDetail>("MovieapprovalDetails").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PostproductionPlaning>("PostproductionPlanings").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PostproductionProgress>("PostproductionProgress").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PostproductionprogressMember>("PostproductionprogressMembers").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PreproductionExpense>("PreproductionExpenses").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PreproductionMember>("PreproductionMembers").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PreproductionPlaning>("PreproductionPlanings").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PreproductionProgress>("PreproductionProgress").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PreproductionprogressMember>("PreproductionprogressMembers").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PreproductionSegment>("PreproductionSegments").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<PreproductionsegmentMember>("PreproductionsegmentMembers").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Team>("Teams").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<TeamMember>("TeamMembers").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Topic>("Topics").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<TopicDocument>("TopicDocuments").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<TopicMember>("TopicMembers").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<User>("Users").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<UserRight>("UserRights").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<Video>("Videos").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<UserRole>("UserRoles").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<RoleRight>("RoleRights").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    odataBuilder.EntitySet<ElasticField>("ElasticFields").EntityType.HasKey(x => x.Id).Expand(5).Count().Page(100, 100);
    return odataBuilder.GetEdmModel();
}