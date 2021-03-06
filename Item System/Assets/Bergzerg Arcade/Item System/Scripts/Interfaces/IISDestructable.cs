﻿using UnityEngine;
using System.Collections;

namespace BoredEagle.ItemSystem
{
	public interface IISDestructable 
	{
	
		int Durability { get; }
		int MaxDurability { get; }
		void TakeDamage(int amount);
		void Repair();
		void Break();

	}
}