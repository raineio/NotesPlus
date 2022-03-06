using NotesPlus.Managers;
using Zenject;

namespace NotesPlus.Installers
{
	public class GameInstaller : Installer
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<NoteScalingManager>().AsSingle();
		}
	}
}