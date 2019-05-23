using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipelineSteps : MonoBehaviour
{
	//private ArrayList doneOp = new ArrayList();

	private Queue doneOp = new Queue();

	public GameObject IF, ID, EX, MEM, WB;
	public GameObject IF_ID, ID_EX, EX_MEM, MEM_WB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			if(WB.GetComponent<WBBehavior>().oper != null)
				doneOp.Enqueue(WB.GetComponent<WBBehavior>().oper);

			WB.GetComponent<WBBehavior>().oper = MEM.GetComponent<MEMBehavior>().oper;
			MEM.GetComponent<MEMBehavior>().oper = EX.GetComponent<EXBehavior>().oper;
			MEM_WB.GetComponent<MEM_WBBehavior>().oper = EX.GetComponent<EXBehavior>().oper;
			EX.GetComponent<EXBehavior>().oper = ID.GetComponent<IDBehavior>().oper;
			EX_MEM.GetComponent<EX_MEMBehavior>().oper = ID.GetComponent<IDBehavior>().oper;
			ID.GetComponent<IDBehavior>().oper = IF.GetComponent<IFBehavior>().oper;
			ID_EX.GetComponent<ID_EXBehavior>().oper = IF.GetComponent<IFBehavior>().oper;
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			IF.GetComponent<IFBehavior>().oper = ID.GetComponent<IDBehavior>().oper;
			IF_ID.GetComponent<IF_IDBehavior>().oper = ID.GetComponent<IDBehavior>().oper;
			ID.GetComponent<IDBehavior>().oper = EX.GetComponent<EXBehavior>().oper;
			ID_EX.GetComponent<ID_EXBehavior>().oper = EX.GetComponent<EXBehavior>().oper;
			EX.GetComponent<EXBehavior>().oper = MEM.GetComponent<MEMBehavior>().oper;
			EX_MEM.GetComponent<EX_MEMBehavior>().oper = MEM.GetComponent<MEMBehavior>().oper;
			MEM.GetComponent<MEMBehavior>().oper = WB.GetComponent<WBBehavior>().oper;
			MEM_WB.GetComponent<MEM_WBBehavior>().oper = WB.GetComponent<WBBehavior>().oper;

			if (doneOp.Count > 0)
				WB.GetComponent<WBBehavior>().oper = (GameObject)doneOp.Dequeue();
			else
				WB.GetComponent<WBBehavior>().oper = null;
		}
	}
}
