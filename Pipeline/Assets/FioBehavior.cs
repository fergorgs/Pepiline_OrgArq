using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FioBehavior : MonoBehaviour
{
    private TextMesh textMesh = null;

    // Start is called before the first frame update
    void Awake()
    {
        textMesh = GetComponentInChildren<TextMesh>();
    }

    public void ChangeDisplay(string str)
    {
        if(textMesh != null) textMesh.text = str;
        Debug.Log(str);
    }

}
