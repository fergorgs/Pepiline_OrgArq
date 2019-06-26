using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEMBehavior : GenericStepBehavior
{
	//public GameObject oper;

	public GameObject addULA, address, writeData, readData, ULAOut1, ULAOut2, rd;

	private void Start()
	{

	}

    // Update is called once per frame
    public override void UpdateMe()
    {
		if (oper != null)
		{
            OpScript operation = oper.GetComponent<OpScript>();

            switch (operation.getTipo())
			{
				case OpScript.Tipo.TipoR:
                    string ularesult = "conteudo(" + operation.rt + ") + " + "conteudo(" + operation.rs + ")";

                    addULA.GetComponent<SpriteRenderer>().color = operation.onColor;
					addULA.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

					address.GetComponent<SpriteRenderer>().color = Color.white;
                    address.GetComponent<FioBehavior>().ChangeDisplay("");

					writeData.GetComponent<SpriteRenderer>().color = Color.white;
                    writeData.GetComponent<FioBehavior>().ChangeDisplay("");

                    readData.GetComponent<SpriteRenderer>().color = Color.white;
                    readData.GetComponent<FioBehavior>().ChangeDisplay("");

                    ULAOut1.GetComponent<SpriteRenderer>().color = operation.onColor;
                    ULAOut1.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    ULAOut2.GetComponent<SpriteRenderer>().color = operation.onColor;
                    ULAOut2.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    rd.GetComponent<SpriteRenderer>().color = operation.onColor;
                    rd.GetComponent<FioBehavior>().ChangeDisplay(operation.rd);

                    break;

				case OpScript.Tipo.TipoI:

					addULA.GetComponent<SpriteRenderer>().color = operation.onColor;
					address.GetComponent<SpriteRenderer>().color = Color.white;
					writeData.GetComponent<SpriteRenderer>().color = Color.white;
					readData.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut1.GetComponent<SpriteRenderer>().color = operation.onColor;
					ULAOut2.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd.GetComponent<SpriteRenderer>().color = operation.onColor;

					break;

				case OpScript.Tipo.Lw:

					addULA.GetComponent<SpriteRenderer>().color = operation.onColor;
					address.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData.GetComponent<SpriteRenderer>().color = Color.white;
					readData.GetComponent<SpriteRenderer>().color = operation.onColor;
					ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
					rd.GetComponent<SpriteRenderer>().color = operation.onColor;

					break;

				case OpScript.Tipo.Sw:

					addULA.GetComponent<SpriteRenderer>().color = operation.onColor;
					address.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData.GetComponent<SpriteRenderer>().color = operation.onColor;
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
