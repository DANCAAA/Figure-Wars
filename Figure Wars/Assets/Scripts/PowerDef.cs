using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDef : Consumable {

	public PowerDef(float precio, float porcentaje, float duracion){
	 
		price = precio;
		duration = duracion;
		percent = porcentaje;
	}
}
