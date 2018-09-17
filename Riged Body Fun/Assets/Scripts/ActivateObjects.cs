using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObjects : MonoBehaviour {

	[SerializeField] bool activated = true;

	void Start () {
		// Use this for initialization
	}
	
	// Update is called once per frame
	void Update () {
		this.activateGivenObject(activated);
	}

	public void activateGivenObject(bool yesNo){
		gameObject.SetActive(yesNo);
	}
}
