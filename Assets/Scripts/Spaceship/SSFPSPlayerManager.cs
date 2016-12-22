using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class SSFPSPlayerManager : MonoBehaviour {

	private SSPanelsManager ssPanelsManager;
	private GameObject player;
	private bool wasActive;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		ssPanelsManager = player.GetComponent<SSPanelsManager> ();
		wasActive = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			openPauseMenu ();
		}
	}

	public void enableFPSController(){
		player.GetComponent<FirstPersonController> ().enabled = true;
	}
	public void disableFPSController(){
		player.GetComponent<FirstPersonController> ().enabled = false;
	}
	private void openPauseMenu(){
		if (ssPanelsManager.isActiveInteractionPanel ()) {
			ssPanelsManager.hideInteractionPanel ();
			wasActive = true;
		}
		disableFPSController ();
		ssPanelsManager.showPausePanel ();
	}
	public void closePauseMenu(){
		ssPanelsManager.hidePausePanel ();
		enableFPSController ();
		if (wasActive) {
			ssPanelsManager.showInteractionPanel ();
		}
	}
	public void LoadSceneByIndex(int sceneIndex){
		SceneManager.LoadScene (sceneIndex);
	}
}
