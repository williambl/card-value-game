using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinyJson;

public class CardCreator : MonoBehaviour {

    void Start () {
        Debug.Log(GameManager.cardPath);
        ImportCardsFromDirectory(GameManager.cardPath);
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public void ImportCardsFromDirectory (string path) {
        foreach (string file in Directory.GetFiles(path)) {
            string name = Path.GetFileNameWithoutExtension(file);
            string json = File.ReadAllText(file);

            CardRegistry.registry.Add(
                    CreateCardGameObject(JSONtoDict(json), name)
                    .GetComponent<CardComponent>().card);
        }
    }

    Dictionary<string, int> JSONtoDict (string json) {
        return JSONParser.FromJson<Dictionary<string, int>>(json);
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
