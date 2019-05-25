using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputHandler : MonoBehaviour
{
	public enum inputType { TipoR, TipoI, LW, SW, nop };

	public inputType tipo;

	public GameObject dropMenu, field1PH, field2PH, field3PH;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		tipo = (inputType) dropMenu.GetComponent<Dropdown>().value;

		switch (tipo)
		{
			case inputType.TipoR:

				field1PH.GetComponentInChildren<Text>().text = "rd...";
				field2PH.GetComponentInChildren<Text>().text = "rt...";
				field3PH.GetComponentInChildren<Text>().text = "rs...";
				break;

			case inputType.TipoI:

				field1PH.GetComponentInChildren<Text>().text = "rd...";
				field2PH.GetComponentInChildren<Text>().text = "rt...";
				field3PH.GetComponentInChildren<Text>().text = "Imm...";
				break;

			case inputType.LW:

				field1PH.GetComponentInChildren<Text>().text = "rd...";
				field2PH.GetComponentInChildren<Text>().text = "Imm...";
				field3PH.GetComponentInChildren<Text>().text = "rs...";
				break;

			case inputType.SW:

				field1PH.GetComponentInChildren<Text>().text = "rd...";
				field2PH.GetComponentInChildren<Text>().text = "Imm...";
				field3PH.GetComponentInChildren<Text>().text = "rs...";
				break;

			case inputType.nop:

				field1PH.GetComponentInChildren<Text>().text = "null";
				field2PH.GetComponentInChildren<Text>().text = "null";
				field3PH.GetComponentInChildren<Text>().text = "null";
				break;
		}
    }
}
