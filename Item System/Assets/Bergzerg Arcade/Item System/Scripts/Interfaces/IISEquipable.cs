using UnityEngine;
using System.Collections;

namespace BoredEagle.ItemSystem
{
	public interface IISEquipable
	{
		ISEquipmentSlot EquipmentSlot { get; }
		bool Equip();
	}
}