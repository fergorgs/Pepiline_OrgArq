using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ID_EXBehavior : MonoBehaviour
{
	public GameObject oper;

	public GameObject A, B, imm, ir20, ir15;

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

					A.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm.GetComponent<SpriteRenderer>().color = Color.white;
					ir20.GetComponent<SpriteRenderer>().color = Color.white;
					ir15.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.TipoI:

					A.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = Color.white;
					imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ir20.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ir15.GetComponent<SpriteRenderer>().color = Color.white;

					break;

				case OpScript.Tipo.Lw:

					A.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = Color.white;
					imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ir20.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ir15.GetComponent<SpriteRenderer>().color = Color.white;

					break;

				case OpScript.Tipo.Sw:

					A.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					B.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ir20.GetComponent<SpriteRenderer>().color = Color.white;
					ir15.GetComponent<SpriteRenderer>().color = Color.white;

					break;
			}
		}
		else
		{
			A.GetComponent<SpriteRenderer>().color = Color.white;
			B.GetComponent<SpriteRenderer>().color = Color.white;
			imm.GetComponent<SpriteRenderer>().color = Color.white;
			ir20.GetComponent<SpriteRenderer>().color = Color.white;
			ir15.GetComponent<SpriteRenderer>().color = Color.white;
		}
	}
}
