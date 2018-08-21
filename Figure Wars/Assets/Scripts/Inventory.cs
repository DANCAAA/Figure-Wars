using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;
	public float oro = (float)Currency.Type1; 

    private void ToList()
    {

    }

    private void Consume()
    {

    }

    private void Equip()
    {

    }

	public void Discard(Item items, int cantidad)
    {
		if (items is Consumable) {
			oro += (items.price / 2) * cantidad;

		} 
    }
}
