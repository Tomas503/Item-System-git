using UnityEngine;
using System.Collections;

namespace BoredEagle.ItemSystem
{
	public interface IISStackable
	{
		int MaxStack { get; }
		int Stack(int amount);			//default value of zero

	}
}
