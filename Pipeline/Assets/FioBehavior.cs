using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FioBehavior : MonoBehaviour
{
    private TextMesh textMesh = null;
    private string info = "";

    // Start is called before the first frame update
    void Awake()
    {
        textMesh = GameObject.FindGameObjectWithTag("Info").GetComponent<TextMesh>();
    }

    public void ChangeDisplay(string str)
    {
        info = str;
    }

    private void OnMouseEnter()
    {
        if (textMesh != null) textMesh.text = info;
        Debug.Log("Entered");
    }

    private void OnMouseExit()
    {
        if (textMesh != null) textMesh.text = "";
        Debug.Log("Exited");
    }

}
