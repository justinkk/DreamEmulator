using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SentimentAnalyzer))]
[RequireComponent(typeof(InputField))]
public class TextInput : MonoBehaviour {
  /** Processor for the text. */
  SentimentAnalyzer sentimentAnalyzer;

  /** Handler for text input. */
  InputField inputField;

	// Use this for initialization
	void Start () {
    sentimentAnalyzer = GetComponent<SentimentAnalyzer>();
    inputField = GetComponent<InputField>();

    // Add a listener for text changing.
    inputField.onValueChanged.AddListener(delegate {OnValueChanged(); });

    // TODO listen for EndEdit or submit event?
	}

  public void OnValueChanged() {
    Debug.Log(inputField.text);
  }
}
