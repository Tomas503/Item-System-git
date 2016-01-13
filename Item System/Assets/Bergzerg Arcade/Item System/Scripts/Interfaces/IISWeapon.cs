using UnityEngine;
using System.Collections;

namespace BoredEagle.ItemSystem
{
	public interface IISWeapon
	{
		int MinDamage { get; set; }
		int Attack();
		
	}
}
