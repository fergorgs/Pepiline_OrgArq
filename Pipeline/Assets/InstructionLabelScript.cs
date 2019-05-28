using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionLabelScript : MonoBehaviour
{
	public GameObject parent;
	public GameObject op;
	private OpScript opScript;

	private TextMesh textMesh;

    // Start is called before the first frame update
    void Start()
    {
		parent = transform.parent.gameObject;

		textMesh = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
		op = parent.GetComponent<GenericStepBehavior>().oper;

		if (op != null)
		{
			opScript = op.GetComponent<OpScript>();
			switch (opScript.tipo)
			{
				case OpScript.Tipo.TipoR:

					textMesh.text = "add " + opScript.rd + ", " + opScript.rs + ", " + opScript.rt;
					break;

				case OpScript.Tipo.TipoI:

					textMesh.text = "addi " + opScript.rd + ", " + opScript.rs + ", " + opScript.imm;
					break;

				case OpScript.Tipo.Lw:

					textMesh.text = "lw " + opScript.rd + " " + opScript.imm + "(" + opScript.rs + ")";
					break;

				case OpScript.Tipo.Sw:

					textMesh.text = "sw " + opScript.rd + " " + opScript.imm + "(" + opScript.rs + ")";
					break;
			}
		}
		else
			textMesh.text = "";
	}
}
