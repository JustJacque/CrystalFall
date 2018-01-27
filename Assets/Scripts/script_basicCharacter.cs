using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_basicCharacter : MonoBehaviour {

public float baseSpeed;
public float jumpForce;
public int mobility;
int currentMobility;
public float power;
public float health;

private Rigidbody2D rb2d;

	void Awake (){
		rb2d = GetComponent<Rigidbody2D>();

	}

	void Start () {
		currentMobility = 0;
	}
	
	// Update is called once per frame
	void Update () {
	Movement();
	Jump();
	}

	void Movement (){
			
	if ( Input.GetKey(KeyCode.D)){
			transform.localScale = new Vector3(1, 1, 1);
			transform.position += Vector3.right * (baseSpeed * Time.deltaTime);

		}

	else if ( Input.GetKey(KeyCode.A)){
			transform.localScale = new Vector3(-1, 1, 1);
			transform.position += Vector3.left * (baseSpeed * Time.deltaTime);
	}

	else if ( Input.GetKey(KeyCode.E)){
			transform.position += Vector3.right * ((baseSpeed * 0.5f) * Time.deltaTime);
	}

	else if ( Input.GetKey(KeyCode.Q)){
			transform.position += Vector3.left * ((baseSpeed * 0.5f) * Time.deltaTime);
	}
	}

	void Jump (){
		if (Input.GetKeyDown(KeyCode.Space) && currentMobility<mobility){

		currentMobility +=1;
		rb2d.AddForce(new Vector2(0f, jumpForce));

		}

	}

	void Grounded (){
		currentMobility = 0;

	}
}
