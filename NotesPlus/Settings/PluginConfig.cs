using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace NotesPlus.Settings
{
	public class PluginConfig
	{
		public virtual bool IsEnabled { get; set; }
	}
}