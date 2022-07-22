#if UNITY_EDITOR

using UnityEditor;

namespace OriGames.EditorExtensions
{
	public class ForceRecompiler : ScriptableWizard
	{
		[MenuItem("Tools/ForceRecompile")]
		static void CreateWizard()
		{
			UnityEditor.Compilation.CompilationPipeline.RequestScriptCompilation();
		}
	}
}
#endif

