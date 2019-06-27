using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEMBehavior : GenericStepBehavior
{
	//public GameObject oper;

	public GameObject addULA, address, writeData, readData, ULAOut1, ULAOut2, rd;

    // Update is called once per call
    public override void UpdateMe()
    {
		if (oper != null)
		{
            OpScript operation = oper.GetComponent<OpScript>();
            string ularesult = "";
            switch (operation.getTipo())
			{
				case OpScript.Tipo.TipoR:
                    ularesult = "conteudo(" + operation.rs + ") + " + "conteudo(" + operation.rt + ")";

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
                    ularesult = "conteudo(" + operation.rs + ") + " + operation.imm;

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

				case OpScript.Tipo.Lw:
                    ularesult = "conteudo(" + operation.rs + ") + " + operation.imm;

                    addULA.GetComponent<SpriteRenderer>().color = operation.onColor;
                    addULA.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

					address.GetComponent<SpriteRenderer>().color = operation.onColor;
                    address.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    writeData.GetComponent<SpriteRenderer>().color = Color.white;
                    writeData.GetComponent<FioBehavior>().ChangeDisplay("");

                    readData.GetComponent<SpriteRenderer>().color = operation.onColor;
                    readData.GetComponent<FioBehavior>().ChangeDisplay(StringFormat.mem(ularesult));

                    ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
                    ULAOut1.GetComponent<FioBehavior>().ChangeDisplay("");

                    ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
                    ULAOut2.GetComponent<FioBehavior>().ChangeDisplay("");

                    rd.GetComponent<SpriteRenderer>().color = operation.onColor;
                    rd.GetComponent<FioBehavior>().ChangeDisplay(operation.rd);

                    break;

				case OpScript.Tipo.Sw:

                    ularesult = "conteudo(" + operation.rs + ") + " + operation.imm;

                    addULA.GetComponent<SpriteRenderer>().color = operation.onColor;
                    addULA.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    address.GetComponent<SpriteRenderer>().color = operation.onColor;
                    address.GetComponent<FioBehavior>().ChangeDisplay(ularesult);

                    writeData.GetComponent<SpriteRenderer>().color = operation.onColor;
                    writeData.GetComponent<FioBehavior>().ChangeDisplay(StringFormat.cont(operation.rd));

                    readData.GetComponent<SpriteRenderer>().color = Color.white;
                    readData.GetComponent<FioBehavior>().ChangeDisplay("");

                    ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
                    ULAOut1.GetComponent<FioBehavior>().ChangeDisplay("");

                    ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
                    ULAOut2.GetComponent<FioBehavior>().ChangeDisplay("");

                    rd.GetComponent<SpriteRenderer>().color = Color.white;
                    rd.GetComponent<FioBehavior>().ChangeDisplay("");

                    break;
			}
		}
		else
		{
			addULA.GetComponent<SpriteRenderer>().color = Color.white;
            addULA.GetComponent<FioBehavior>().ChangeDisplay("");
            address.GetComponent<SpriteRenderer>().color = Color.white;
            address.GetComponent<FioBehavior>().ChangeDisplay("");
            writeData.GetComponent<SpriteRenderer>().color = Color.white;
            writeData.GetComponent<FioBehavior>().ChangeDisplay("");
            readData.GetComponent<SpriteRenderer>().color = Color.white;
            readData.GetComponent<FioBehavior>().ChangeDisplay("");
            ULAOut1.GetComponent<SpriteRenderer>().color = Color.white;
            ULAOut1.GetComponent<FioBehavior>().ChangeDisplay("");
            ULAOut2.GetComponent<SpriteRenderer>().color = Color.white;
            ULAOut2.GetComponent<FioBehavior>().ChangeDisplay("");
            rd.GetComponent<SpriteRenderer>().color = Color.white;
            rd.GetComponent<FioBehavior>().ChangeDisplay("");
        }
	}
}
