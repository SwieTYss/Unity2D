using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Animator anim;
    bool dirToRight = true;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        float horizontalMove = Input.GetAxis("Horizontal");

        anim.SetFloat("speed", Mathf.Abs(horizontalMove));

        dirToRight = dirToRight;

	}
}
