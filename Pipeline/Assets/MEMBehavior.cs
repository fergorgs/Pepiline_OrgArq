using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEMBehavior : MonoBehaviour
{
	public GameObject oper;

	public GameObject addULA, address, writeData, readData, ULAOut1, ULAOut2, rd;

	private void Start()
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

					addULA.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					address.GetComponent<SpriteRenderer>().color = Color.white;
					writeData.GetComponent<SpriteRenderer>().color = Color.white;
					readData.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.TipoI:

					addULA.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					address.GetComponent<SpriteRenderer>().color = Color.white;
					writeData.GetComponent<SpriteRenderer>().color = Color.white;
					readData.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Lw:

					addULA.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					address.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData.GetComponent<SpriteRenderer>().color = Color.white;
					readData.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
					rd.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.Sw:

					addULA.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					address.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					writeData.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					readData.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
					rd.GetComponent<SpriteRenderer>().color = Color.white;

					break;
			}
		}
		else
		{
			addULA.GetComponent<SpriteRenderer>().color = Color.white;
			address.GetComponent<SpriteRenderer>().color = Color.white;
			writeData.GetComponent<SpriteRenderer>().color = Color.white;
			readData.GetComponent<SpriteRenderer>().color = Color.white;
			ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
			ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
			rd.GetComponent<SpriteRenderer>().color = Color.white;
		}
	}
}
