using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFBehavior : MonoBehaviour
{

	public GameObject oper;

	public GameObject fioRS, fioRT, dataReadRS, dataReadRT, imm, rd1, rd2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (oper != null)
		{
			switch (oper.GetComponent<OpScript>().getTipo())
			{
				case OpScript.Tipo.TipoR:

					fioRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					fioRT.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataReadRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataReadRT.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm.GetComponent<SpriteRenderer>().color = Color.white;
					rd1.GetComponent<SpriteRenderer>().color = Color.white;
					rd2.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;

					break;

				case OpScript.Tipo.TipoI:

					fioRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					fioRT.GetComponent<SpriteRenderer>().color = Color.white;
					dataReadRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataReadRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;

					break;

				case OpScript.Tipo.Lw:

					fioRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					fioRT.GetComponent<SpriteRenderer>().color = Color.white;
					dataReadRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataReadRT.GetComponent<SpriteRenderer>().color = Color.white;
					imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;

					break;

				case OpScript.Tipo.Sw:

					fioRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					fioRT.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataReadRS.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					dataReadRT.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					imm.GetComponent<SpriteRenderer>().color = oper.GetComponent<OpScript>().onColor;
					rd1.GetComponent<SpriteRenderer>().color = Color.white;
					rd2.GetComponent<SpriteRenderer>().color = Color.white;

					break;
			}
		}
    }
}
