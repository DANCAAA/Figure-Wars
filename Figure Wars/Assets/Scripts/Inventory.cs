using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;
	public Consumable[] powerUps;
	private NonConsumable[] equipables = new NonConsumable[3];
	public int oro = (int)Currency.Type1; 



	private void Consume(Consumable item)
    {
		if (item.cantidad > 0) {
			item.Consume ();
			item.cantidad -= 1;
		} else {
		
			Debug.Log ("No tienes PowerUPs");
		}
    }


	private void Equip(NonConsumable item)
    {
		for (int i = 0; i < equipables.Length; i++) {

			if (equipables [i] == null) {
				equipables[i] = item;
				item.equiped = true;
				item.Equip ();
				break;
			}

			if (i == 2) {
			
				Debug.Log ("Ya tienes 3 items equipados");
			}
		}

    }

	public void Discard(Item items, int cantidad)
    {
		if (items is Consumable) {
			oro += Mathf.RoundToInt((items.price / 2f) * cantidad);
		} 
    }
}
