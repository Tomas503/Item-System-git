using UnityEngine;
using System.Collections;

namespace BoredEagle.ItemSystem
{
	public interface IISEquipmentSlot
	{
		string Name { get; set; }
		Sprite Icon { get; set; }
	}
}