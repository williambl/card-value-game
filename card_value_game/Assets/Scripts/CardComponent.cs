using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardComponent : MonoBehaviour {

    public Card card;
    public GameObject propertyObj;

    void Start () {
        foreach (var property in card.properties) {
            GameObject newProperty = Instantiate(propertyObj, transform);
            newProperty.GetComponent<PropertyComponent>().propertyName = property.Key;
            newProperty.GetComponent<PropertyComponent>().propertyValue = property.Value;
        }
    }

}
