using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXBehavior : GenericStepBehavior
{
	//public GameObject oper;

	public GameObject input1, input2, readDataRT, imm1, imm2, imm3, rd1, rd2, rdFinal, dataWrite1, dataWrite2, ULAOut;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	public override void UpdateMe()
	{

        if (oper != null)
		{
            OpScript operationScript = oper.GetComponent<OpScript>();
			switch (operationScript.getTipo())
			{
				case OpScript.Tipo.TipoR:

					input1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    input1.GetComponent<FioBehavior>().ChangeDisplay("conteudo(" + operationScript.rs + ")");

					input2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    input2.GetComponent<FioBehavior>().ChangeDisplay("conteudo(" + operationScript.rt + ")");

                    readDataRT.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    readDataRT.GetComponent<FioBehavior>().ChangeDisplay("conteudo(" + operationScript.rt + ")");

                    imm1.GetComponent<SpriteRenderer>().color = Color.white;
                    imm1.GetComponent<FioBehavior>().ChangeDisplay("");
                    imm2.GetComponent<SpriteRenderer>().color = Color.white;
                    imm2.GetComponent<FioBehavior>().ChangeDisplay("");
                    imm3.GetComponent<SpriteRenderer>().color = Color.white;
                    imm3.GetComponent<FioBehavior>().ChangeDisplay("");

                    rd1.GetComponent<SpriteRenderer>().color = Color.white;
                    rd1.GetComponent<FioBehavior>().ChangeDisplay("");

                    rd2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    rd2.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rd);

                    rdFinal.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    rdFinal.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rd);

                    dataWrite1.GetComponent<SpriteRenderer>().color = Color.white;
                    dataWrite1.GetComponent<FioBehavior>().ChangeDisplay("");

                    dataWrite2.GetComponent<SpriteRenderer>().color = Color.white;
                    dataWrite2.GetComponent<FioBehavior>().ChangeDisplay("");

                    ULAOut.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    ULAOut.GetComponent<FioBehavior>().ChangeDisplay("conteudo(" + operationScript.rt + ") + " + "conteudo(" + operationScript.rs + ")");

					break;

				case OpScript.Tipo.TipoI:

					input1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					input2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					readDataRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					imm2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					imm3.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					rd1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;
					rdFinal.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					dataWrite1.GetComponent<SpriteRenderer>().color = Color.white;
					dataWrite2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut.GetComponent<SpriteRenderer>().color = operationScript.onColor;

					break;

				case OpScript.Tipo.Lw:

					input1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					input2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					readDataRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					imm2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					imm3.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					rd1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;
					rdFinal.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					dataWrite1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					dataWrite2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					ULAOut.GetComponent<SpriteRenderer>().color = operationScript.onColor;

					break;

				case OpScript.Tipo.Sw:

					input1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					input2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					readDataRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					imm2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					imm3.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					rd1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;
					rdFinal.GetComponent<SpriteRenderer>().color = Color.white;
					dataWrite1.GetComponent<SpriteRenderer>().color = Color.white;
					dataWrite2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut.GetComponent<SpriteRenderer>().color = operationScript.onColor;

					break;

				default:

					input1.GetComponent<SpriteRenderer>().color = Color.white;
					input2.GetComponent<SpriteRenderer>().color = Color.white;
					readDataRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm1.GetComponent<SpriteRenderer>().color = Color.white;
					imm2.GetComponent<SpriteRenderer>().color = Color.white;
					imm3.GetComponent<SpriteRenderer>().color = Color.white;
					rd1.GetComponent<SpriteRenderer>().color = Color.white;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;
					rdFinal.GetComponent<SpriteRenderer>().color = Color.white;
					dataWrite1.GetComponent<SpriteRenderer>().color = Color.white;
					dataWrite2.GetComponent<SpriteRenderer>().color = Color.white;
					ULAOut.GetComponent<SpriteRenderer>().color = Color.white;
					break;
			}
		}
		else
		{
			input1.GetComponent<SpriteRenderer>().color = Color.white;
			input2.GetComponent<SpriteRenderer>().color = Color.white;
			readDataRT.GetComponent<SpriteRenderer>().color = Color.white;
			imm1.GetComponent<SpriteRenderer>().color = Color.white;
			imm2.GetComponent<SpriteRenderer>().color = Color.white;
			imm3.GetComponent<SpriteRenderer>().color = Color.white;
			rd1.GetComponent<SpriteRenderer>().color = Color.white;
			rd2.GetComponent<SpriteRenderer>().color = Color.white;
			rdFinal.GetComponent<SpriteRenderer>().color = Color.white;
			dataWrite1.GetComponent<SpriteRenderer>().color = Color.white;
			dataWrite2.GetComponent<SpriteRenderer>().color = Color.white;
			ULAOut.GetComponent<SpriteRenderer>().color = Color.white;
		}
	}
}
