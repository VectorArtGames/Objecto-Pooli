﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : Unit
{
	private void Start()
	{
		Attack(this, damage);
	}
}
