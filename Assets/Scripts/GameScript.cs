using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour {

	public float time;
	public int sanity;

	public Text dayTimer;
	public Text sanityPercent;
	public Image sanityComplete;
	public Image sanityMedium;
	public Image sanityCritical;
	public Image noSanity;
	// Use this for initialization
	void Start () {
		sanity = 100;
		time = 60;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
