using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	float minSpeed=0.1f;
	float maxSpeed=2f;
	float acc;
	float h;
	float v;
	private Animator anim;
	private AudioSource foodSteps;
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		foodSteps = gameObject.GetComponent<AudioSource>();
		acc = minSpeed;
	}

	void Update () {
		h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("Vertical");
		h *= Time.deltaTime;
		v *= Time.deltaTime;
		if (v > 0f){
			if (acc < maxSpeed)
				acc += Time.deltaTime;
			anim.SetFloat ("speed",1f);
			transform.Translate (0f,0f,v*20f);
			if(!foodSteps.isPlaying)
				foodSteps.Play();
		}
		else{
			anim.SetFloat ("speed",0f);
			foodSteps.Stop();
			acc = minSpeed;
		}
		foodSteps.pitch = acc;
		transform.Rotate (0f,h*100f,0f);

	}
}