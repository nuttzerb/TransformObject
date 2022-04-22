using System;
using UnityEngine;
using UnityEngine.UI;
public class TransformObject : MonoBehaviour
{
    [Header("GameObject")]
    [SerializeField] GameObject obj;
    [SerializeField] GameObject inputFieldX;
    [SerializeField] GameObject inputFieldY;
    [SerializeField] GameObject inputFieldZ;
    [Header("Variable")]
    float x,y,z;
    void Awake()
    {
        QualitySettings.vSyncCount = 0;  // VSync disabled
        Application.targetFrameRate = 60;// Lock fps 60
    }

    private void InputStringToFloat() // parse float
    {
        try
        {
            x = float.Parse(inputFieldX.GetComponent<Text>().text);
            y = float.Parse(inputFieldY.GetComponent<Text>().text);
            z = float.Parse(inputFieldZ.GetComponent<Text>().text);
        }
        catch (FormatException e)
        {
            Debug.Log(e);
        }
    }
    public void SetDefault()
    {
        InputStringToFloat();
        obj.transform.position = new Vector3(0, 0, 0);
        obj.transform.rotation = Quaternion.Euler(0, 0, 0);
        obj.transform.localScale = new Vector3(1, 1, 1);
        x = 0; y = 0; z = 0;
    }
    public void Translate()
    {
        InputStringToFloat();
        obj.transform.position = new Vector3(x, y, z);
    }
    public void Rotate()
    {
        float startTime = Time.realtimeSinceStartup;
        Debug.Log("Time started: " + startTime);

        InputStringToFloat();
        obj.transform.rotation = Quaternion.Euler(x, y, z);

        float finishTime = Time.realtimeSinceStartup;
        Debug.Log("Time finished: " + finishTime);
        Debug.Log("Time for function: " + (finishTime - startTime));
    }
    public void Scale()
    {
        InputStringToFloat();
        obj.transform.localScale = new Vector3(x, y, z);
    }
}
