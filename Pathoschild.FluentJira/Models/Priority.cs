using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>The relative priority of an issue.</summary>
	public class Priority : EntityWithID
	{
		/// <summary>The display name of the priority.</summary>
		public string Name { get; set; }

		/// <summary>The URL of the display icon.</summary>
		public string IconUrl { get; set; }
	}
}