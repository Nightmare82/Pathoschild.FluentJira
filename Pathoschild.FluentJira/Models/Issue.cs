using Pathoschild.FluentJira.Models.Abstract;

namespace Pathoschild.FluentJira.Models
{
	/// <summary>A JIRA issue.</summary>
	public class Issue : EntityWithID
	{
		/// <summary>The unique string which identifies this issue.</summary>
		public string Key { get; set; }

		/// <summary>The additional issue fields.</summary>
		public IssueFields Fields { get; set; }
	}
}