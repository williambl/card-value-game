using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreator : MonoBehaviour {

    public Card testCard;
    public GameObject cardObj;

    void Start () {
        Dictionary<string, int> testCardDict = new Dictionary<string, int>();
        testCardDict.Add("test property", 50);
        testCardDict.Add("test property 2", 100);
        testCard = new Card(testCardDict, "testCard");

        GameObject newCardObj = Instantiate(cardObj, GameObject.Find(
                    "Canvas").transform);
        newCardObj.GetComponent<CardComponent>().card = testCard;
    }
	
    // Update is called once per frame
    void Update () {
		
    }
}
