using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class ComputerDetector : MonoBehaviour {

	private SSPanelsManager ssPanelsManager;
	private SSFPSPlayerManager ssFPSManager;
	private PlayVideo playVideo;
	private GameObject player;
	private GameObject fpsPlayer;
	private Camera fpsCamera;
	private Camera pcCamera;
	private Camera videoCamera;

	private bool triggerEnter;

	void Start(){
		player = GameObject.Find ("Player");
		ssPanelsManager = player.GetComponent<SSPanelsManager> ();
		ssFPSManager = player.GetComponent<SSFPSPlayerManager> ();
		fpsPlayer = GameObject.Find ("FirstPersonCharacter");
		fpsCamera = fpsPlayer.GetComponent<Camera> ();
		pcCamera = GameObject.Find ("PCCamera").GetComponent<Camera>();
		pcCamera.enabled = false;
		//videoCamera = GameObject.Find ("VideoCamera").GetComponent<Camera>();
		//videoCamera.enabled = false;
		//playVideo = player.GetComponent<PlayVideo>();
		triggerEnter = false;
	}

	void Update () {
		if (triggerEnter) {
			if (Input.GetKeyDown (KeyCode.I)) {
				showPCCamera ();
			}
		}
	}

	void OnTriggerEnter(Collider otro){
		ssPanelsManager.showInteractionPanel ();
		triggerEnter = true;
	}

	void OnTriggerExit(Collider otro){
		ssPanelsManager.hideInteractionPanel ();
		triggerEnter = false;
	}

	private void showPCCamera(){
		ssFPSManager.disableFPSController ();
		ssPanelsManager.hideInteractionPanel ();
		fpsCamera.enabled = false;
		pcCamera.enabled = true;
		ssPanelsManager.showCursor ();
	}
	public void hidePCCamera(){
		pcCamera.enabled = false;
		fpsCamera.enabled = true;
		ssPanelsManager.showInteractionPanel ();
		ssFPSManager.enableFPSController ();
	}
	public void travelToVenus(){
		pcCamera.enabled = false;
		ssFPSManager.LoadSceneByIndex (Globals.SCENE_VENUS);
		//videoCamera.enabled = true;
		//playVideo.playVideo ();
	}
	public void travelToIcenet(){
		pcCamera.enabled = false;
		ssFPSManager.LoadSceneByIndex (Globals.SCENE_ICENET);
		//videoCamera.enabled = true;
		//playVideo.playVideo ();
	}
}
