using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFBehavior : GenericStepBehavior
{
	//public GameObject oper;

	public GameObject instruction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (oper != null)
			instruction.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
		else
			instruction.GetComponent<SpriteRenderer>().color = Color.white;
	}
}
