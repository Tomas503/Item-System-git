﻿using UnityEngine;
using System.Collections;


namespace BoredEagle.ItemSystem
{
	[System.Serializable]
	public class ISQuality : IISQuality {
		[SerializeField]string _name;
		[SerializeField]Sprite  _icon;
		
		
		public ISQuality()
		{
			_name = "";
			_icon = new Sprite();
			GUIUtility.keyboardControl = 0;
			
		}
		
		public ISQuality(string name, Sprite icon)
		{
			_name = name;
			_icon = icon;
		}
		
	
		#region IISQuality implementation
	
		public string Name {
			get {return _name;}
			set {_name = value;}
		}
	
		public Sprite Icon {
			get {return _icon;}
			set {_icon = value;}
		}
	
		#endregion
	
	
	
	}
}