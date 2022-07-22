#if UNITY_EDITOR

using UnityEditor;

namespace LogBreaker.Utils
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

