using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardComponent : MonoBehaviour {

    public Card card;
    public GameObject propertyObj;

    void Start () {
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
