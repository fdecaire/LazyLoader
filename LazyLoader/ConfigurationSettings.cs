using System.Collections.Generic;
using System.Linq;
using LazyLoader.DAL;

namespace LazyLoader
{
	public class ConfigurationSettings
	{
		private static List<string> _Data = null;
		private static List<string> Data
		{
			get
			{
				if (_Data == null)
				{
					using (var db = new ConfigDataContext())
					{
						_Data = (from ps in db.ProgramSettings 
								 where ps.Setting 
								 select ps.Name).ToList();
					}
				}
				return _Data;
			}
		}

		public static bool RequirePassword
		{
			get 
			{
				return Data.Contains("RequirePassword");
			}
		}

		public static bool ShowUserName
		{
			get
			{
				return Data.Contains("ShowUserName");
			}
		}

		public static bool ShowUserPicture
		{
			get
			{
				return Data.Contains("ShowUserPicture");
			}
		}

		public static bool AllowUserToChangePicture
		{
			get
			{
				return Data.Contains("AllowUserToChangePicture");
			}
		}
	}
}
