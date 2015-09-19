using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LazyLoader.DAL
{
	[Table("ProgramSetting")]
	public class ProgramSetting
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public bool Setting { get;set;}
	}
}
