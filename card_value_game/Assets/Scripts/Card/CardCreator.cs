using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyJson;

public class CardCreator : MonoBehaviour {

    void Start () {
        string jsonString = "{ \"test0\": 100, \"test1\": 50  }";
        Debug.Log(jsonString);
        Dictionary<string, int> testCardDict = JSONParser.FromJson<Dictionary<string, int>>(jsonString);
        CardRegistry.registry.Add(CreateCardGameObject(testCardDict, "testCard").GetComponent<CardComponent>().card);
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
