﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
	public levelData lvlData;

	public void testSave()
	{
		lvlData= new levelData();

		JSONManager.SaveIntoJson(lvlData);
	}

	public void TestLoad()
	{
		levelData prof= JSONManager.LoadFromJson();
		if(prof != null)
		{
			Debug.Log("loaded level data");  
			lvlData= prof;
		}
		else
		{
			Debug.Log("failed to load level data");  
		}
	}


	/*[SerializeField] private GameObject ingTest;
	public int count;

	// Start is called before the first frame update
	void Start()
	{
		StartCoroutine(SpawnIngredient());
	}

	public IEnumerator SpawnIngredient()
	{
		for(int i= 0; i <= count; i++)
		{
			yield return new WaitForSeconds(2);
			GameObject ing= Instantiate(ingTest, transform.position, transform.rotation);
			if(ing) Destroy(ing, 5);
		}
	}*/
}