using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class WardrobeDetector : MonoBehaviour {

	private SSPanelsManager ssPanelsManager;
	private SSFPSPlayerManager ssFPSManager;
	private GameObject player;

	private bool triggerEnter;

	void Start(){
		player = GameObject.Find ("Player");
		ssPanelsManager = player.GetComponent<SSPanelsManager> ();
		ssFPSManager = player.GetComponent<SSFPSPlayerManager> ();
		triggerEnter = false;
	}

	void Update () {
		if (triggerEnter) {
			if (Input.GetKeyDown (KeyCode.I)) {
				openMenu ();
			}
		}
	}

	void OnTriggerEnter(Collider other){
		ssPanelsManager.showInteractionPanel ();
		triggerEnter = true;
	}

	void OnTriggerExit(Collider otro){
		ssPanelsManager.hideInteractionPanel ();
		triggerEnter = false;
	}

	private void openMenu(){
		ssFPSManager.disableFPSController ();
		ssPanelsManager.hideInteractionPanel ();
		ssPanelsManager.showWardrobePanel ();
	}

	public void closeMenu(){
		ssPanelsManager.showInteractionPanel ();
		ssPanelsManager.hideWardrobePanel ();
		ssFPSManager.enableFPSController ();
	}

	public void onClickChangeButton(){
		ssPanelsManager.toggleDress ();
	}
	public void onClickBackButton(){
		closeMenu ();
	}
}
