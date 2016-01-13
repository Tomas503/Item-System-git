	using UnityEngine;
using System.Collections;


namespace BoredEagle.ItemSystem
{
	public interface IISObject {
		
		//Name
		//Value - gold value
		//icon - description 
		//burden - weight plus bulk
		//qualitylevel
		
		string Name {get; set; }
		int Value {get; set; }
		Sprite Icon {get; set; }
		int Burden {get; set; }
		ISQuality Quality {get; set;}
		
		
		//these go to other item interfaces
		//equip
		//questItem flag

		//prefabs
	
	}
}