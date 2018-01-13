using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager {

    public static GameObject cardObj = Resources.Load("Prefabs/Card") as GameObject;

    public static string cardPath = Path.Combine(Application.persistentDataPath, "card_jsons");
}
