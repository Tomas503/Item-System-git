using UnityEngine;
using UnityEditor;
using System.Collections;

namespace BoredEagle.ItemSystem.Editor
{
	public partial class ISObjectEditor 
	{
		Vector2 _scrollPos = Vector2.zero;
		int _listViewWidth = 200;
		int _listWiewButtonWidth = 190;
		int _listWiewButtonHeight = 25;

		int _selectedIndex = -1;



		void ListView()
		{
			if(state != DisplayState.NONE)
				return;										//dont show the rest of the things in listView

			_scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth));

			for(int cnt = 0; cnt < database.Count; cnt++)
			{
				if(GUILayout.Button(database.Get(cnt).Name, "box", GUILayout.Width(_listWiewButtonWidth), GUILayout.Height(_listWiewButtonHeight)))
				{
					_selectedIndex = cnt;
					tempWeapon = new ISWeapon(database.Get(cnt));
					showNewWeaponDetails = true;
					state = DisplayState.DETAILS;

				}

			}
			
			GUILayout.EndScrollView();
		}
	}
}
