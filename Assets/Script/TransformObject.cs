using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TransformObject : MonoBehaviour
{
    [Header("GameObject")]
    public GameObject obj;
    public GameObject inputFieldX;
    public GameObject inputFieldY;
    public GameObject inputFieldZ;
    [Header("Variable")]
    float x,y,z;
    Transform startTransform;
    private void Start()
    {
        startTransform = obj.transform;
        FloatParse();
    }

    private void FloatParse()
    {
        try
        {
            x = float.Parse(inputFieldX.GetComponent<Text>().text);
            y = float.Parse(inputFieldY.GetComponent<Text>().text);
            z = float.Parse(inputFieldZ.GetComponent<Text>().text);
        }
        catch (FormatException e)
        {
            Debug.Log("Loi dinh dang - " + e);
        }
    }

    public void SetDefault()
    {
        obj.transform.position = new Vector3(0, 0, 0);
        obj.transform.rotation = Quaternion.Euler(0, 0, 0);
        obj.transform.localScale = new Vector3(1, 1, 1);

    }
    public void Translate()
    {
        FloatParse();
         obj.transform.position = new Vector3(x, y, z);
    }
    public void Rotate()
    {
        FloatParse();
        //  obj.transform.Rotate(new Vector3(x, y, z)); 
        obj.transform.rotation = Quaternion.Euler(x, y, z);
    }
    public void Scale()
    {
        FloatParse();
        obj.transform.localScale = new Vector3(x, y, z);
    }
}
