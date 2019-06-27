using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegsLabelScript : MonoBehaviour
{
	private GameObject father;

	private TextMesh text;

	private double r, g, b;

    // Start is called before the first frame update
    void Start()
    {
		father = transform.parent.gameObject;

		text = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
		r = 0.5 - (father.GetComponent<SpriteRenderer>().color.r - 0.5);
		g = 0.5 - (father.GetComponent<SpriteRenderer>().color.g - 0.5);
		b = 0.5 - (father.GetComponent<SpriteRenderer>().color.b - 0.5);

		//text.color = new Color((float)r, (float)g, (float)b);
    }
}
