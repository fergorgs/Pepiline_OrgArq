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
    public override void UpdateMe()
    {
		if (oper != null)
		{
            OpScript operation = oper.GetComponent<OpScript>();
            switch (operation.getTipo())
			{
				case OpScript.Tipo.TipoR:
					string ularesult = "conteudo(" + operation.rt + ") + " + "conteudo(" + operation.rs + ")";
                    readData.GetComponent<SpriteRenderer>().color = Color.white;
					readData.GetComponent<FioBehavior>().ChangeDisplay("");

					ULAOut1.GetComponent<SpriteRenderer>().color = operation.onColor;
                    ULAOut1.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    ULAOut2.GetComponent<SpriteRenderer>().color = operation.onColor;
                    ULAOut2.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    ULAOut3.GetComponent<SpriteRenderer>().color = operation.onColor;
                    ULAOut3.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    writeData1.GetComponent<SpriteRenderer>().color = operation.onColor;
                    writeData1.GetComponent<FioBehavior>().ChangeDisplay(ularesult);
                    writeData2.GetComponent<SpriteRenderer>().color = operation.onColor;
                    writeData2.GetComponent<FioBehavior>().ChangeDisplay(ularesult);
                    writeData3.GetComponent<SpriteRenderer>().color = operation.onColor;
                    writeData3.GetComponent<FioBehavior>().ChangeDisplay(ularesult);
                    writeData4.GetComponent<SpriteRenderer>().color = operation.onColor;
                    writeData4.GetComponent<FioBehavior>().ChangeDisplay(ularesult);
                    writeData5.GetComponent<SpriteRenderer>().color = operation.onColor;
                    writeData5.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    string rd = operation.rd;
                    rd1.GetComponent<SpriteRenderer>().color = operation.onColor;
                    rd2.GetComponent<SpriteRenderer>().color = operation.onColor;
                    rd3.GetComponent<SpriteRenderer>().color = operation.onColor;
                    rd4.GetComponent<SpriteRenderer>().color = operation.onColor;
                    rd5.GetComponent<SpriteRenderer>().color = operation.onColor;
                    rd1.GetComponent<FioBehavior>().ChangeDisplay(rd);
                    rd2.GetComponent<FioBehavior>().ChangeDisplay(rd);
                    rd3.GetComponent<FioBehavior>().ChangeDisplay(rd);
                    rd4.GetComponent<FioBehavior>().ChangeDisplay(rd);
                    rd5.GetComponent<FioBehavior>().ChangeDisplay(rd);

                    break;

				case OpScript.Tipo.TipoI:

					readData.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut1.GetComponent<SpriteRenderer>().color = operation.onColor;
					ULAOut2.GetComponent<SpriteRenderer>().color = operation.onColor;
					ULAOut3.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData1.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData2.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData3.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData4.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData5.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd1.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd2.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd3.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd4.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd5.GetComponent<SpriteRenderer>().color = operation.onColor;

					break;

				case OpScript.Tipo.Lw:

					readData.GetComponent<SpriteRenderer>().color = operation.onColor;
					ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut3.GetComponent<SpriteRenderer>().color = Color.white;
					writeData1.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData2.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData3.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData4.GetComponent<SpriteRenderer>().color = operation.onColor;
					writeData5.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd1.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd2.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd3.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd4.GetComponent<SpriteRenderer>().color = operation.onColor;
					rd5.GetComponent<SpriteRenderer>().color = operation.onColor;

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
