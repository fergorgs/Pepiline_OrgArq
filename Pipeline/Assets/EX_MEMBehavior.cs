using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_MEMBehavior : MonoBehaviour
{
	public GameObject oper;

	public GameObject ULAOut, B, rd;

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

					ULAOut.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = Color.white;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.TipoI:

					ULAOut.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = Color.white;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Lw:

					ULAOut.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = Color.white;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Sw:

					ULAOut.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd.GetComponent<SpriteRenderer>().color = Color.white;

					break;
			}
		}
		else
		{
			ULAOut.GetComponent<SpriteRenderer>().color = Color.white;
			B.GetComponent<SpriteRenderer>().color = Color.white;
			rd.GetComponent<SpriteRenderer>().color = Color.white;
		}
	}
}
