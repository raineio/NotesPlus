using System;
using IPA;
using NotesPlus.Installers;
using NotesPlus.Settings;
using IPALogger = IPA.Logging.Logger;
using SiraUtil.Zenject;

namespace NotesPlus
{
	[Plugin(RuntimeOptions.DynamicInit), NoEnableDisable]
	public class Plugin
	{

		[Init]
		public void Init(Zenjector zenjector, IPALogger logger)
		{
			zenjector.UseLogger(logger);

			zenjector.Install(Location.App, _ =>
				_.Bind(typeof(IDisposable)).To<PluginConfig>().AsCached());
			zenjector.Install<MenuInstaller>(Location.Menu);
		}
	}
}