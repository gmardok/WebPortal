namespace Concord.WebPortal.WebApi
{
    using Concord.WebPortal.WebApi.Infrastructure;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.Identity.Web;
    using Microsoft.OpenApi.Models;
    using System.IdentityModel.Tokens.Jwt;

    public static class ServiceInitializer
    {
        public static IServiceCollection RegisterApplicationServices(
                                    this IServiceCollection services,
                                    ConfigurationManager configuration)
        {
            // This is required to be instantiated before the OpenIdConnectOptions starts getting configured.
            // By default, the claims mapping will map claim names in the old format to accommodate older SAML applications.
            // 'http://schemas.microsoft.com/ws/2008/06/identity/claims/role' instead of 'roles'
            // This flag ensures that the ClaimsIdentity claims collection will be built from the claims in the token
            JwtSecurityTokenHandler.DefaultMapInboundClaims = false;

            // Adds Microsoft Identity platform (AAD v2.0) support to protect this Api
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddMicrosoftIdentityWebApi(options =>
                    {
                        options.Events = new JwtBearerEvents();

                        /// <summary>
                        /// Below you can do extended token validation and check for additional claims, such as:
                        ///
                        /// - check if the caller's tenant is in the allowed tenants list via the 'tid' claim (for multi-tenant applications)
                        /// - check if the caller's account is homed or guest via the 'acct' optional claim
                        /// - check if the caller belongs to right roles or groups via the 'roles' or 'groups' claim, respectively
                        ///
                        /// Bear in mind that you can do any of the above checks within the individual routes and/or controllers as well.
                        /// For more information, visit: https://docs.microsoft.com/azure/active-directory/develop/access-tokens#validate-the-user-has-permission-to-access-this-data
                        /// </summary>

                        options.Events.OnTokenValidated = async context =>
                        {
                            string[] allowedClientApps = { configuration["AzureAd:ClientId"] }; // In this scenario, client and service share the same clientId and this app's API only allows call from its own SPA

                            string clientappId = context?.Principal?.Claims.FirstOrDefault(x => x.Type == "azp" || x.Type == "appid")?.Value;

                            if (!allowedClientApps.Contains(clientappId))
                            {
                                throw new System.Exception("This client is not authorized");
                            }

                            await Task.CompletedTask;
                        };
                    }, options => { configuration.Bind("AzureAd", options); });

            // The following lines code instruct the asp.net core middleware to use the data in the "roles" claim in the Authorize attribute and User.IsInrole()
            // See https://docs.microsoft.com/aspnet/core/security/authorization/roles for more info.
            services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                // The claim in the Jwt token where App roles are available.
                options.TokenValidationParameters.RoleClaimType = "roles";
            });

            // Adding authorization policies that enforce authorization using Azure AD roles.
            services.AddAuthorization(options =>
            {
                options.AddPolicy(
                    AuthorizationPolicies.AssignmentToSaleTypeMappingReadRoleRequired,
                    policy => policy.RequireRole(configuration["AzureAd:Roles:SaleTypeMappingRead"], configuration["AzureAd:Roles:SaleTypeMappingReadWrite"]));
                options.AddPolicy(
                    AuthorizationPolicies.AssignmentToSaleTypeMappingReadWriteRoleRequired,
                    policy => policy.RequireRole(configuration["AzureAd:Roles:SaleTypeMappingReadWrite"]));
            });

            RegisterCustomDependencies(services);

            RegisterSwagger(services);

            return services;
        }

        private static void RegisterCustomDependencies(IServiceCollection services)
        {
            // Add services to the container.
        }

        private static void RegisterSwagger(IServiceCollection services)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(option =>
            {
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
                });
                option.AddSecurityRequirement(new OpenApiSecurityRequirement
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

            services.AddCors(o => o.AddPolicy("default", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
        }
    }
}
