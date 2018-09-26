using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SentimentAnalyzer : MonoBehaviour {
  private static string FILENAME = "Assets/TSVs/AFINN/AFINN-111.txt";

  private static Dictionary<string, int> sentimentMap;

	// Use this for initialization
	void Start () {
    try {
      using (StreamReader reader = new StreamReader(FILENAME)) {
        sentimentMap = new Dictionary<string, int>();

        string line;

        while ((line = reader.ReadLine()) != null) {
          string[] splitLine = line.Split('\t');
          sentimentMap.Add(splitLine[0], System.Int32.Parse(splitLine[1]));
        }
      }
    } catch (System.Exception e) {
      Debug.Log("Could not read file.");
      Debug.Log(e.Message);
    }
	}

  void ProcessText(string text) {
    //To lowercase

//    string currentWord = "";
//    for (int i = 0; i < text.Length(); i++) {

        //if alphabetic, add to word
        //else,
           //end previous word
           //if previous word is in dictionary
              //do something with the number result.
              //(temporary, debug.log word and value.)
              //(later, add it to a queue of the last few words, which we will average somehow

    // this'll eventually be different for the final version of submitted text, compared
    // to what it looks like as the game is going.
          
//    }
  }
}
