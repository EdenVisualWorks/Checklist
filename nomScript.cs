using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nomScript : MonoBehaviour
{

    public bool valueEntered = false;
    public bool valuePresent = false;

    private string newValue;

    
    public InputField QuantityField;
    

    public void valueCheck()
    {
        valueEntered = true;
    }

    public void SaveValue(string check)
    {
        if (valueEntered == true)   
        {
            valuePresent = true;
            QuantityField.text = PlayerPrefs.SetString("saveValue", check);            
        }
    }

    public void LoadValue()
    {
        if (valuePresent == true)
        {
            QuantityField.text = PlayerPrefs.GetString("saveValue");
            Debug.Log("Values Loaded!");
        }
    }

    

    public void Update()
    {
        Debug.Log(valueEntered + "yey");
        Debug.Log(valueEntered + "woo");
    }

    
    
}
