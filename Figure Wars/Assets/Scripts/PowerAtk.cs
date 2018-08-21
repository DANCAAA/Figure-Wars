using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerAtk : Consumable {

	public PowerAtk(float precio, float porcentaje, float duracion){

		price = precio;
		duration = duracion;
		percent = porcentaje;
	}
}
