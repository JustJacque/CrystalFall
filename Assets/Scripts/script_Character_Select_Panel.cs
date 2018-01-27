using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script_Character_Select_Panel : MonoBehaviour {

public string [] characters;
public string [] weapons;
public GameObject [] characterweaponPrefab;
public Text selectionText;
int characterChoice;
int weaponChoice;
int characterweaponIndex;
void Start(){

	characterChoice = 0;
	weaponChoice = 0;
	 
}

public void  CharacterSelect (int characterSelection) {
	characterChoice = characterSelection;
	selectionText.text = " Character:" + characters[characterChoice] +"\n Weapon: " + weapons[weaponChoice];
}

public void WeaponSelect (int weaponSelection) {
	weaponChoice = weaponSelection;
	selectionText.text = " Character:" + characters[characterChoice] + "\n Weapon: " + weapons[weaponChoice];
}

public void Readypressed()	{
	Debug.Log ("Ready Pressed");
	if (characterChoice == 0){
		Debug.Log ("No Character selected");
		return;

}

	else if (weaponChoice == 0) {
		Debug.Log ("No Weapon selected");
		return;

		}
		else {
		Debug.Log ("Character and Weapon selected");
		Debug.Log ("Destroying Character Select Panel");
		characterweaponIndex = (((characterChoice -1)*10) + (weaponChoice -1));
		Debug.Log ("characterweaponIndex is: " + characterweaponIndex) ;


		Destroy(this.gameObject);

		}
	}
}
