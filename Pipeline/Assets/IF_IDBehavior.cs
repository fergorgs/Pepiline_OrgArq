using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_IDBehavior : MonoBehaviour
{
	public GameObject oper;

	public GameObject instr;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (oper != null)
			instr.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
		else
			instr.GetComponent<SpriteRenderer>().color = Color.white;

	}
}
