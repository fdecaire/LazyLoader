using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoader
{
	class Program
	{
		static void Main(string[] args)
		{
			if (ConfigurationSettings.RequirePassword)
			{
				Console.WriteLine("Require Password");
			}

			if (ConfigurationSettings.AllowUserToChangePicture)
			{
				Console.WriteLine("Allow User to Change Picture");
			}

			if (ConfigurationSettings.ShowUserName)
			{
				Console.WriteLine("Show User Name");
			}

			if (ConfigurationSettings.ShowUserPicture)
			{
				Console.WriteLine("Show User Picture");
			}

			Console.ReadKey();
		}
	}
}
