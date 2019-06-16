using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipelineSteps : MonoBehaviour
{
	//private ArrayList doneOp = new ArrayList();

	private Stack doneOp = new Stack();

	public GameObject IF, ID, EX, MEM, WB;
	public GameObject IF_ID, ID_EX, EX_MEM, MEM_WB;

	public GameObject dropMenu, field1, field2, field3;

	private GameObject seedInstruction;

	// Start is called before the first frame update
	void Start()
    {
		seedInstruction = GameObject.FindGameObjectWithTag("seedOp");
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.RightArrow))
			oneRight();

		if (Input.GetKeyDown(KeyCode.LeftArrow))
			oneLeft();

		Debug.Log("name = " + seedInstruction.name);
	}

	//Debug.Log("name = " + seedInstruction.name);



	public void insertInstruction()
	{
		GameObject newOp = Instantiate(seedInstruction);

		Color cl;
		float rg = Random.Range(0f, 1f);

		if(rg <= 3.3f)
			cl = new Color(Random.Range(0.5f, 1f), Random.Range(0f, 0.5f), Random.Range(0f, 0.5f));
		else if (rg <= 6.6f)
			cl = new Color(Random.Range(0f, 0.5f), Random.Range(0.5f, 1f), Random.Range(0f, 0.5f));
		else
			cl = new Color(Random.Range(0f, 0.5f), Random.Range(0f, 0.5f), Random.Range(0.5f, 1f));

		newOp.GetComponent<OpScript>().onColor = cl;
		newOp.tag = null;

		Debug.Log("color = " + newOp.GetComponent<OpScript>().onColor);

		switch (dropMenu.GetComponent<Dropdown>().value)
		{
			case 0: //Tipo R

				newOp.GetComponent<OpScript>().tipo = OpScript.Tipo.TipoR;
				newOp.GetComponent<OpScript>().rd = field1.GetComponent<Text>().text;
				newOp.GetComponent<OpScript>().rs = field3.GetComponent<Text>().text;
				newOp.GetComponent<OpScript>().rt = field2.GetComponent<Text>().text;
				break;

			case 1: //Tipo I

				newOp.GetComponent<OpScript>().tipo = OpScript.Tipo.TipoI;
				newOp.GetComponent<OpScript>().rd = field1.GetComponent<Text>().text;
				newOp.GetComponent<OpScript>().rs = field2.GetComponent<Text>().text;
				newOp.GetComponent<OpScript>().imm = field3.GetComponent<Text>().text;
				break;

			case 2: //LW

				newOp.GetComponent<OpScript>().tipo = OpScript.Tipo.Lw;
				newOp.GetComponent<OpScript>().rd = field1.GetComponent<Text>().text;
				newOp.GetComponent<OpScript>().imm = field2.GetComponent<Text>().text;
				newOp.GetComponent<OpScript>().rs = field3.GetComponent<Text>().text;
				break;

			case 3: //Sw

				newOp.GetComponent<OpScript>().tipo = OpScript.Tipo.Sw;
				newOp.GetComponent<OpScript>().rd = field1.GetComponent<Text>().text;
				newOp.GetComponent<OpScript>().imm = field2.GetComponent<Text>().text;
				newOp.GetComponent<OpScript>().rs = field3.GetComponent<Text>().text;
				break;

			case 4: //nop

				newOp = null;
				break;
		}

		oneRight();
		IF.GetComponent<IFBehavior>().oper = newOp;
	}

	public void oneRight()
	{
		if (WB.GetComponent<WBBehavior>().oper != null)
			doneOp.Push(WB.GetComponent<WBBehavior>().oper);

		WB.GetComponent<WBBehavior>().oper = MEM.GetComponent<MEMBehavior>().oper;
		MEM_WB.GetComponent<MEM_WBBehavior>().oper = MEM.GetComponent<MEMBehavior>().oper;
		MEM.GetComponent<MEMBehavior>().oper = EX.GetComponent<EXBehavior>().oper;
		EX_MEM.GetComponent<EX_MEMBehavior>().oper = EX.GetComponent<EXBehavior>().oper;
		EX.GetComponent<EXBehavior>().oper = ID.GetComponent<IDBehavior>().oper;
		ID_EX.GetComponent<ID_EXBehavior>().oper = ID.GetComponent<IDBehavior>().oper;
		ID.GetComponent<IDBehavior>().oper = IF.GetComponent<IFBehavior>().oper;
		IF_ID.GetComponent<IF_IDBehavior>().oper = IF.GetComponent<IFBehavior>().oper;
		IF.GetComponent<IFBehavior>().oper = null;
	}

	public void oneLeft()
	{
		IF.GetComponent<IFBehavior>().oper = ID.GetComponent<IDBehavior>().oper;
		ID.GetComponent<IDBehavior>().oper = EX.GetComponent<EXBehavior>().oper;
		IF_ID.GetComponent<IF_IDBehavior>().oper = ID.GetComponent<IDBehavior>().oper;
		EX.GetComponent<EXBehavior>().oper = MEM.GetComponent<MEMBehavior>().oper;
		ID_EX.GetComponent<ID_EXBehavior>().oper = EX.GetComponent<EXBehavior>().oper;
		MEM.GetComponent<MEMBehavior>().oper = WB.GetComponent<WBBehavior>().oper;
		EX_MEM.GetComponent<EX_MEMBehavior>().oper = MEM.GetComponent<MEMBehavior>().oper;

		if (doneOp.Count > 0)
		{
			WB.GetComponent<WBBehavior>().oper = (GameObject)doneOp.Pop();
			MEM_WB.GetComponent<MEM_WBBehavior>().oper = WB.GetComponent<WBBehavior>().oper;
		}
		else
		{
			WB.GetComponent<WBBehavior>().oper = null;
			MEM_WB.GetComponent<MEM_WBBehavior>().oper = null;
		}
	}
}
