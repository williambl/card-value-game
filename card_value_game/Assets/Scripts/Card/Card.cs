using System.Collections;
using System.Collections.Generic;

public class Card {

    public string name;
    public Dictionary<string, int> properties;

    public Card (Dictionary<string, int> propertiesIn, string nameIn) {
        name = nameIn;
        properties = propertiesIn;
    }

    public void addProperty (string propName, int propValue) {
        properties.Add(propName, propValue);
    }
}
