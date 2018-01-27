using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_Floor : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
        	Debug.Log (col.gameObject.name + " hit floor");
        	col.gameObject.SendMessage ("Grounded");
             }
}
}