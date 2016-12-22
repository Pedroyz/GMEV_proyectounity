using UnityEngine;
using System.Collections;

public static class Globals{

	public static readonly string DRESS_TYPE_INDOOR = "Ropa de interior";
	public static readonly string DRESS_TYPE_OUTDOOR = "Traje espacial";

	public static string current_dress = DRESS_TYPE_INDOOR;

	public static GameObject interactionPanel;


	public static string getCurrentDress(){
		return current_dress;
	}
	public static void setCurrentDress(string new_dress){
		current_dress = new_dress;
	}


	public static void setInteractionPanel (GameObject iP){
		
	}
	public static GameObject getInteractionPanel(){
		return interactionPanel;
	}
}
