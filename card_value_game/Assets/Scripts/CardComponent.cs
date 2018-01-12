using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardComponent : MonoBehaviour {

    public Card card;
    public GameObject propertyObj;

    void Start () {
        transform.Find("Name").GetComponent<Text>().text = card.name;

        int i = 0;
        foreach (var property in card.properties) {
            GameObject newProperty = Instantiate(propertyObj, transform);
            newProperty.GetComponent<PropertyComponent>().propertyName = property.Key;
            newProperty.GetComponent<PropertyComponent>().propertyValue = property.Value;
            
            newProperty.transform.Translate(0, i*32, 0);
            i++;
        }
    }

}
