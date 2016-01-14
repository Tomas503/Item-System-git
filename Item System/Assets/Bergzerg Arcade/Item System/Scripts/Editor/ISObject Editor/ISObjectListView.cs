using UnityEngine;
//using UnityEditor;
using System.Collections;

namespace BoredEagle.ItemSystem.Editor
{
	public partial class ISObjectEditor 
	{
		Vector2 _scrollPos = Vector2.zero;
		int _listViewWidth = 200;
		void ListView()
		{
			_scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth));
	
			GUILayout.Label("List View");

//			for(int cnt = 0; cnt < database.Count; cnt++)
//			{
//				EditorGUILayout.LabelField( database.Get(cnt).Name);
//			}
			
			GUILayout.EndScrollView();
		}
	}
}
