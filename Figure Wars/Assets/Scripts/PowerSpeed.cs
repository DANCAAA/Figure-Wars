﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : Consumable {


	public PowerSpeed(int precio, float porcentaje, float duracion){

		price = precio;
		duration = duracion;
		percent = porcentaje;
	}

	public void Consume(){
	}
}
