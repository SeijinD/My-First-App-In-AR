using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim2 : MonoBehaviour, IVirtualButtonEventHandler {
	
	public Animator skeleton_Anim;
	public GameObject skeleton_Object;
	
	// Use this for initialization
	void Start () {
		skeleton_Object = GameObject.Find("VirtualButton2");
		skeleton_Object.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		skeleton_Anim.GetComponent<Animator>();
	}
	
	public void OnButtonPressed(VirtualButtonBehaviour vb){
		skeleton_Anim.Play("skeleton_Animation2");
		Debug.Log("BTN Pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		skeleton_Anim.Play("none");
		Debug.Log("BTN Pressed");
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
