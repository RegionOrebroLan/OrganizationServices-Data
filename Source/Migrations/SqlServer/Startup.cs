using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RegionOrebroLan.OrganizationServices.Data.DependencyInjection.Extensions;

namespace SqlServer
{
	public class Startup
	{
		#region Methods

		public virtual void Configure() { }

		public virtual void ConfigureServices(IServiceCollection services)
		{
			if(services == null)
				throw new ArgumentNullException(nameof(services));

			services.AddSqlServerDatabaseContext(builder => builder.UseSqlServer("?"));
		}

		#endregion
	}
}