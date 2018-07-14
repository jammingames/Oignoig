using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EntityData
{
	public string name;
	public string description;

	public int fight;
	public int dash;
	public int gusto;
	public int currentHP;
	public int maxHP;
	public int bonusHP;
	public int damage;
	public int blockAmt;
	public float critChance;
	public float hitChance;
	public float dodgeChance;

	public int initiative;
	public int threat;
}

public class Entity : MonoBehaviour {

	public EntityData data;


}
