using Karma.Models.BaseEntitys;

namespace Karma.Models
{
	public class Slider:BaseAuditable
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
