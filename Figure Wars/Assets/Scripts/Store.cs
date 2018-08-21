using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
	public List<Item> items;
	public Inventory playerInventory;


	public void Sell(Item item)
    {
		if (item is NonConsumable) {

			NonConsumable itm = item as NonConsumable;

			if (!itm.bought) {
			
				playerInventory.items.Add (item);
				playerInventory.oro -= item.price;
				itm.bought = false;

			} else {
			
				Debug.Log ("Ya tienes el Item");
			}
		} else {

			if (item.price < playerInventory.oro) {

				playerInventory.items.Add (item);
				playerInventory.oro -= item.price;
			
			} else {
			

				Debug.Log ("Dinero insuficiente");
			}
		}

    }

	public void ToList(){

	
	}
		
}
