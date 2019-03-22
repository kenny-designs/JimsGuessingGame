using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
  [SerializeField] float spinSpeed = 1;
  [SerializeField] float maxSpin = 30f;


  void Update() {
    transform.rotation = Quaternion.Euler(0f, maxSpin * Mathf.Sin(Time.time * spinSpeed), 0f);
  }
}
