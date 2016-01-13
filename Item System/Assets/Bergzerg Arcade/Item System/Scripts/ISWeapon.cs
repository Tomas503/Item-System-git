using UnityEditor;
using UnityEngine;
using System.Collections;

namespace BoredEagle.ItemSystem
{
	[System.Serializable]
	public class ISWeapon : ISObject, IISWeapon, IISDestructable, IISEquipable, IISGameobject
	{
		[SerializeField] int _minDamage;
		[SerializeField] int _durability;
		[SerializeField] int _maxDurability;
		[SerializeField] ISEquipmentSlot _equipmentSlot;
		[SerializeField] GameObject _prefab;
		
		
		
		public ISWeapon()
		{
			_equipmentSlot = new ISEquipmentSlot();
		}
		
		
		public ISWeapon(int durability, int maxDurability, ISEquipmentSlot equipmentSlot, GameObject prefab)
		{
			_durability = durability;
			_maxDurability = maxDurability;
			_equipmentSlot = equipmentSlot;
			_prefab = prefab;
		}
		
		public int MinDamage
		{
			get{ return _minDamage;}
			set{ _minDamage = value;}
		}
		
		
		
		public int Attack()
		{
			throw new System.NotImplementedException();
		}
		
		
		
		public int Durability
		{
			get { return _durability; }
			
		}
		
		
		
		public int MaxDurability
		{
			get { return _maxDurability; }
		}
		
		
		
		public void TakeDamage(int amount)
		{
			_durability -= amount;
			
			if (_durability < 0 )
				_durability = 0;
				
		}
		
		
		
		public void Repair()
		{
			_maxDurability--;
			
			if(_maxDurability > 0)
				_durability = _maxDurability;
		}
		
		
		
		//Reduce the durability to 0
		// not sure what to do with this method
		public void Break()
		{
			_durability = 0;
		}
		
		
		
		public ISEquipmentSlot EquipmentSlot
		{
			get { return _equipmentSlot;}
		}
		
		public bool Equip()
		{
			throw new System.NotImplementedException();
		}
		
		
		public GameObject Prefab
		{
			get
			{
				return _prefab;
			}
			
		}




		// This code is going to be placed in a new class later on


		public override void OnGUI()				//this is a function not unity's OnGUI 
		{
			base.OnGUI();

			_minDamage = System.Convert.ToInt32( EditorGUILayout.TextField("Damage : ", _minDamage.ToString()));
			_durability = System.Convert.ToInt32( EditorGUILayout.TextField("Durability : ", _durability.ToString()));
			_maxDurability = System.Convert.ToInt32( EditorGUILayout.TextField("Max Durability : ", _maxDurability.ToString()));

			DisplayEquipmentSlot();
			DisplayPrefab();

		}



		public void DisplayEquipmentSlot()
		{
			GUILayout.Label("Equipment");
		}



		public void DisplayPrefab()
		{
			GUILayout.Label("Prefab");
		}



	}
}
