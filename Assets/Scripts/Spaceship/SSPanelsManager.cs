using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SSPanelsManager : MonoBehaviour {

	private GameObject interactionPanel;
	private GameObject pauseMenuPanel;
	private GameObject wardrobePanel;
	private Text dressText;

	void Awake(){
		interactionPanel = GameObject.Find ("InteractionPanel");
		interactionPanel.SetActive (false);

		pauseMenuPanel = GameObject.Find ("PauseMenuPanel");
		pauseMenuPanel.SetActive (false);

		dressText = GameObject.Find ("DressType").GetComponent<Text>();
		wardrobePanel = GameObject.Find ("WardrobePanel");
		wardrobePanel.SetActive (false);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showInteractionPanel(){
		interactionPanel.SetActive (true);
	}
	public void hideInteractionPanel(){
		interactionPanel.SetActive (false);
	}

	public bool isActiveInteractionPanel(){
		return interactionPanel.activeSelf;
	}

	public void showWardrobePanel(){
		wardrobePanel.SetActive (true);
	}
	public void hideWardrobePanel(){
		wardrobePanel.SetActive (false);
	}

	public void showPausePanel(){
		pauseMenuPanel.SetActive (true);
	}
	public void hidePausePanel(){
		pauseMenuPanel.SetActive (false);
	}

	public void toggleDress(){
		if (Globals.getCurrentDress () == Globals.DRESS_TYPE_INDOOR) {
			Globals.setCurrentDress (Globals.DRESS_TYPE_OUTDOOR);
			dressText.text = Globals.DRESS_TYPE_OUTDOOR;
		}
		else {
			Globals.setCurrentDress (Globals.DRESS_TYPE_INDOOR);
			dressText.text = Globals.DRESS_TYPE_INDOOR;
		}
	}
}
