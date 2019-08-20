using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectCard : MonoBehaviour {
    public Animator cardAnimator;

    // Use this for initialization
    void Start () {
        cardAnimator = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void onMouseEnter() {

        Debug.Log("Click");
    }
}
