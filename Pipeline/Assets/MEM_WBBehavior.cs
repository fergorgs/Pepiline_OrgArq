using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEM_WBBehavior : MonoBehaviour
{
	public GameObject oper;

	public GameObject LMD, B, rd;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (oper != null)
		{
			switch (oper.GetComponent<OpScript>().getTipo())
			{
				case OpScript.Tipo.TipoR:

					LMD.GetComponent<SpriteRenderer>().color = Color.white;
					B.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.TipoI:

					LMD.GetComponent<SpriteRenderer>().color = Color.white;
					B.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Lw:

					LMD.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = Color.white;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Sw:

					LMD.GetComponent<SpriteRenderer>().color = Color.white;
					B.GetComponent<SpriteRenderer>().color = Color.white;
					rd.GetComponent<SpriteRenderer>().color = Color.white;

					break;
			}
		}
		else
		{
			LMD.GetComponent<SpriteRenderer>().color = Color.white;
			B.GetComponent<SpriteRenderer>().color = Color.white;
			rd.GetComponent<SpriteRenderer>().color = Color.white;
		}
	}
}
