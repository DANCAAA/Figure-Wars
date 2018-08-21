using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : Consumable {

	public PowerSpeed(float precio, float porcentaje, float duracion){

		price = precio;
		duration = duracion;
		percent = porcentaje;
	}
}
