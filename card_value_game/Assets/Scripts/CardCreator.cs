using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreator : MonoBehaviour {

    void Start () {
        Dictionary<string, int> testCardDict = new Dictionary<string, int>();
        testCardDict.Add("test property", 50);
        testCardDict.Add("test property 2", 100);
        CreateCardGameObject(testCardDict, "testCard");
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public static Card CreateCard (Dictionary<string, int> dictIn, string nameIn) {
        return new Card(dictIn, nameIn);
    }

    public static GameObject CreateCardGameObject (Dictionary<string, int> dictIn, string nameIn) {
        GameObject newCardObj = Instantiate(GameManager.cardObj, GameObject.Find(
                    "Canvas").transform);
        newCardObj.GetComponent<CardComponent>().card = CreateCard(dictIn, nameIn);
        return newCardObj;
    }
}
