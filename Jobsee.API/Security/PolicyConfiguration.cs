namespace Jobsee.API.Security
{
    public static class PolicyConfiguration
    {
        #region Authorization policy
        public static IServiceCollection AddConfigureAuthorizationPolicies(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequiredAdministrator&Operator", policy =>
                {
                    policy.RequireRole("Administrator", "Operator");
                });

                options.AddPolicy("RequiredAdministrator&Operator&Accountant", policy =>
                {
                    policy.RequireRole("Administrator", "Operator", "Public Accountant");
                });

                options.AddPolicy("RequiredAdministrator&Operator&RH", policy =>
                {
                    policy.RequireRole("Administrator", "Operator", "Human Resource");
                });

            });

            return services;
        }
        #endregion

        #region Cors policy
        public static IServiceCollection AddConfigureCorsPolicies(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder.WithOrigins("http://localhost")
                .AllowAnyMethod()
                .AllowAnyHeader()
                );
            });

            return services;
        }
        #endregion
    }
}
