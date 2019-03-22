using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
  // highest or lowest 
  [SerializeField] int max, min;
  [SerializeField] TextMeshProUGUI guessText = null;

  int guess;

  // Start is called before the first frame update
  void Start() {
    StartGame();
  }

  // our own initialization function
  void StartGame() {
    NextGuess();
  }

  public void OnPressHigher() {
    if (min >= max) return;

    min = guess + 1;
    NextGuess();
  }

  public void OnPressLower() {
    if (min >= max) return;

    max = guess - 1;
    NextGuess();
  }

  void NextGuess() {
    guess = Random.Range(min, max + 1);
    guessText.text = (guess.ToString());
  }
}
