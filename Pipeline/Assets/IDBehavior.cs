using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDBehavior : GenericStepBehavior
{
	//public GameObject oper;

	public GameObject fioRS, fioRT, dataReadRS, dataReadRT, imm, rd1, rd2, toReg1, toReg2, toImm, toRD1, toRD2, fromIf;

	// Update is called once per call
	public override void UpdateMe()
	{
		if (oper != null)
		{
            OpScript operationScript = oper.GetComponent<OpScript>();

            fromIf.GetComponent<SpriteRenderer>().color = operationScript.onColor;

			switch (operationScript.getTipo())
			{
				case OpScript.Tipo.TipoR:

					fioRS.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    fioRS.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rs);

					fioRT.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    fioRT.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rt);

                    dataReadRS.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    dataReadRS.GetComponent<FioBehavior>().ChangeDisplay("conteudo(" + operationScript.rs + ")");

                    dataReadRT.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    dataReadRT.GetComponent<FioBehavior>().ChangeDisplay("conteudo(" + operationScript.rt + ")");

                    imm.GetComponent<SpriteRenderer>().color = Color.white;
                    imm.GetComponent<FioBehavior>().ChangeDisplay("");

					rd1.GetComponent<SpriteRenderer>().color = Color.white;
                    rd1.GetComponent<FioBehavior>().ChangeDisplay("");

                    rd2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
                    rd2.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rd);

                    toReg1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					toReg2.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					toImm.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					toRD1.GetComponent<SpriteRenderer>().color = operationScript.onColor;
					toRD2.GetComponent<SpriteRenderer>().color = operationScript.onColor;

					break;

				case OpScript.Tipo.TipoI:

					fioRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    fioRS.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rs);

                    fioRT.GetComponent<SpriteRenderer>().color = Color.white;
                    fioRT.GetComponent<FioBehavior>().ChangeDisplay("");

                    dataReadRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    dataReadRS.GetComponent<FioBehavior>().ChangeDisplay(StringFormat.cont(operationScript.rs));

                    dataReadRT.GetComponent<SpriteRenderer>().color = Color.white;
                    dataReadRT.GetComponent<FioBehavior>().ChangeDisplay("");

                    imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    imm.GetComponent<FioBehavior>().ChangeDisplay(operationScript.imm);

                    rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    rd1.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rd);

                    rd2.GetComponent<SpriteRenderer>().color = Color.white;
                    rd2.GetComponent<FioBehavior>().ChangeDisplay("");

                    toReg1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toReg2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toImm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toRD1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toRD2.GetComponent<SpriteRenderer>().color = Color.white;

					break;

				case OpScript.Tipo.Lw:

					fioRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    fioRS.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rs);

					fioRT.GetComponent<SpriteRenderer>().color = Color.white;
                    fioRT.GetComponent<FioBehavior>().ChangeDisplay("");

                    dataReadRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    dataReadRS.GetComponent<FioBehavior>().ChangeDisplay(StringFormat.cont(operationScript.rs));

                    dataReadRT.GetComponent<SpriteRenderer>().color = Color.white;
                    dataReadRT.GetComponent<FioBehavior>().ChangeDisplay("");

                    imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    imm.GetComponent<FioBehavior>().ChangeDisplay(operationScript.imm);

                    rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    rd1.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rd);

                    rd2.GetComponent<SpriteRenderer>().color = Color.white;
                    rd2.GetComponent<FioBehavior>().ChangeDisplay("");

                    toReg1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toReg2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toImm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toRD1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toRD2.GetComponent<SpriteRenderer>().color = Color.white;

					break;

				case OpScript.Tipo.Sw:

					fioRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    fioRS.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rs);

                    fioRT.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    fioRT.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rd);

                    dataReadRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    dataReadRS.GetComponent<FioBehavior>().ChangeDisplay(StringFormat.cont(operationScript.rs));

                    dataReadRT.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    dataReadRT.GetComponent<FioBehavior>().ChangeDisplay(operationScript.rt);

                    imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
                    imm.GetComponent<FioBehavior>().ChangeDisplay(operationScript.imm);

                    rd1.GetComponent<SpriteRenderer>().color = Color.white;
                    rd1.GetComponent<FioBehavior>().ChangeDisplay("");

                    rd2.GetComponent<SpriteRenderer>().color = Color.white;
                    rd2.GetComponent<FioBehavior>().ChangeDisplay("");

                    toReg1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toReg2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toImm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					toRD1.GetComponent<SpriteRenderer>().color = Color.white;
					toRD2.GetComponent<SpriteRenderer>().color = Color.white;

					break;
			}
		}
		else
		{
			fromIf.GetComponent<SpriteRenderer>().color = Color.white;
            fromIf.GetComponent<FioBehavior>().ChangeDisplay("");
            fioRS.GetComponent<SpriteRenderer>().color = Color.white;
            fioRS.GetComponent<FioBehavior>().ChangeDisplay("");
            fioRT.GetComponent<SpriteRenderer>().color = Color.white;
            fioRT.GetComponent<FioBehavior>().ChangeDisplay("");
            dataReadRS.GetComponent<SpriteRenderer>().color = Color.white;
            dataReadRS.GetComponent<FioBehavior>().ChangeDisplay("");
            dataReadRT.GetComponent<SpriteRenderer>().color = Color.white;
            dataReadRT.GetComponent<FioBehavior>().ChangeDisplay("");
            imm.GetComponent<SpriteRenderer>().color = Color.white;
            imm.GetComponent<FioBehavior>().ChangeDisplay("");
            rd1.GetComponent<SpriteRenderer>().color = Color.white;
            rd1.GetComponent<FioBehavior>().ChangeDisplay("");
            rd2.GetComponent<SpriteRenderer>().color = Color.white;
            rd2.GetComponent<FioBehavior>().ChangeDisplay("");

            toReg1.GetComponent<SpriteRenderer>().color = Color.white;
			toReg2.GetComponent<SpriteRenderer>().color = Color.white;
			toImm.GetComponent<SpriteRenderer>().color = Color.white;
			toRD1.GetComponent<SpriteRenderer>().color = Color.white;
			toRD2.GetComponent<SpriteRenderer>().color = Color.white;
		}
	}
}
