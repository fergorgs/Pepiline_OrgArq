using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBBehavior : GenericStepBehavior
{
	//public GameObject oper;

	public GameObject readData, ULAOut1, ULAOut2, ULAOut3, writeData1, writeData2, writeData3, writeData4, writeData5, rd1, rd2, rd3, rd4, rd5;

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
					
					readData.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData4.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData5.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd4.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd5.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.TipoI:

					readData.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData4.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData5.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd4.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd5.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Lw:

					readData.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut3.GetComponent<SpriteRenderer>().color = Color.white;
					writeData1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData4.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData5.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd3.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd4.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd5.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Sw:

					readData.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut3.GetComponent<SpriteRenderer>().color = Color.white;
					writeData1.GetComponent<SpriteRenderer>().color = Color.white;
					writeData2.GetComponent<SpriteRenderer>().color = Color.white;
					writeData3.GetComponent<SpriteRenderer>().color = Color.white;
					writeData4.GetComponent<SpriteRenderer>().color = Color.white;
					writeData5.GetComponent<SpriteRenderer>().color = Color.white;
					rd1.GetComponent<SpriteRenderer>().color = Color.white;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;
					rd3.GetComponent<SpriteRenderer>().color = Color.white;
					rd4.GetComponent<SpriteRenderer>().color = Color.white;
					rd5.GetComponent<SpriteRenderer>().color = Color.white;

					break;
			}
		}
		else
		{
			readData.GetComponent<SpriteRenderer>().color = Color.white;
			ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
			ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
			ULAOut3.GetComponent<SpriteRenderer>().color = Color.white;
			writeData1.GetComponent<SpriteRenderer>().color = Color.white;
			writeData2.GetComponent<SpriteRenderer>().color = Color.white;
			writeData3.GetComponent<SpriteRenderer>().color = Color.white;
			writeData4.GetComponent<SpriteRenderer>().color = Color.white;
			writeData5.GetComponent<SpriteRenderer>().color = Color.white;
			rd1.GetComponent<SpriteRenderer>().color = Color.white;
			rd2.GetComponent<SpriteRenderer>().color = Color.white;
			rd3.GetComponent<SpriteRenderer>().color = Color.white;
			rd4.GetComponent<SpriteRenderer>().color = Color.white;
			rd5.GetComponent<SpriteRenderer>().color = Color.white;
		}
	}


}
