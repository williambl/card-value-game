using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropertyComponent : MonoBehaviour {

    public string propertyName;
    public int propertyValue;

    Text nameText;
    Text valueText;
    Image valueSlider;
    
    void Start () {
        nameText = transform.Find("Name").GetComponent<Text>();
        valueText = transform.Find("Slider/Text").GetComponent<Text>();
        valueSlider = transform.Find("Slider").GetComponent<Image>();

        nameText.text = propertyName;
    }

    void Update () {
        valueText.text = propertyValue.ToString();
        valueSlider.fillAmount = propertyValue / 100;
    }
	
}
