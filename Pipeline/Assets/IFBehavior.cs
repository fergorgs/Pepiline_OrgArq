using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFBehavior : GenericStepBehavior
{
	//public GameObject oper;

	public GameObject instruction;

    // Update is called once per frame
    void Update()
    {
		if (oper != null)
        {
			instruction.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
        }
		else
			instruction.GetComponent<SpriteRenderer>().color = Color.white;
	}
}
