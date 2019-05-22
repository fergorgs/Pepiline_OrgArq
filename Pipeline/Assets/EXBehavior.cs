using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXBehavior : MonoBehaviour
{
	public GameObject oper;

	public GameObject input1, input2, readDataRT, imm1, imm2, imm3, rd1, rd2, rdFinal, dataWrite1, dataWrite2, ULAOut;

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

					input1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					input2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					readDataRT.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm1.GetComponent<SpriteRenderer>().color = Color.white;
					imm2.GetComponent<SpriteRenderer>().color = Color.white;
					imm3.GetComponent<SpriteRenderer>().color = Color.white;
					rd1.GetComponent<SpriteRenderer>().color = Color.white;
					rd2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rdFinal.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataWrite1.GetComponent<SpriteRenderer>().color = Color.white;
					dataWrite2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.TipoI:

					input1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					input2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					readDataRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;
					rdFinal.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataWrite1.GetComponent<SpriteRenderer>().color = Color.white;
					dataWrite2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Lw:

					input1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					input2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					readDataRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;
					rdFinal.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataWrite1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataWrite2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Sw:

					input1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					input2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					readDataRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;
					rdFinal.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataWrite1.GetComponent<SpriteRenderer>().color = Color.white;
					dataWrite2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;
			}
		}
	}
}
