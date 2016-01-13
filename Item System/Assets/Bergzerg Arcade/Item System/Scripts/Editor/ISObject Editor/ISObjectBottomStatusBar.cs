using UnityEngine;
using System.Collections;

namespace BoredEagle.ItemSystem.Editor
{
	public partial class ISObjectEditor 
	{
		void BottomStatusBar()
		{
		GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
		GUILayout.Label("Bottom Status View");
		GUILayout.EndHorizontal();	
		}
	}
}
