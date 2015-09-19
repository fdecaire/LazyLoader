using System;
using System.Data.Entity;

namespace LazyLoader.DAL
{
	public class ConfigDataContext : DbContext, IDisposable
	{
		public ConfigDataContext()
			: base(@"My Connection String")
		{

		}

		public DbSet<ProgramSetting> ProgramSettings { get; set; }
	}
}
