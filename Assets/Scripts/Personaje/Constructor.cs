using UnityEngine;
using System.Collections;

public class Prueba : MonoBehaviour {


	public GameObject clon;
	public RaycastHit hit;
	public bool inventario;
	public float altura = 0.0f;
	public bool foundhit;

	// Use this for initialization
	void Start () {

		inventario = false;
		clon = null;
		altura = 0.0f;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKeyDown("mouse 1")){
			inventario = true;
			print (inventario);
		}





		Vector3 dir = transform.TransformDirection(Vector3.forward);
		foundhit = Physics.Raycast(transform.position, dir, out hit);


		if (foundhit){
			print ("entro");
			clon.transform.position = new Vector3(hit.point.x, hit.point.y + altura, hit.point.z);
			if (Input.GetKeyDown("mouse 0")){
				//clon.GetComponent(BoxCollider) = true;
				//clon.GetComponents<BoxCollider>().enabled = false;
				BoxCollider[] TodosLosCollider = clon.GetComponents<BoxCollider>();
				foreach(BoxCollider Collider in TodosLosCollider) Collider.enabled = true;
				clon = null;
				//clon = gameObject.Instantiate(objeto).gameObject;
			}
			if (Input.GetKey(",")){
				//clon.transform.rotation.y += Time.deltaTime * 30.0f;
				clon.transform.eulerAngles = new Vector3(0, clon.transform.eulerAngles.y + Time.deltaTime * 30.0f, 0);
//				objeto.eulerAngles.y += Time.deltaTime * 30;
			}
			if (Input.GetKey(".")){
				clon.transform.eulerAngles = new Vector3(0, clon.transform.eulerAngles.y - Time.deltaTime * 30.0f, 0);
//				clon.transform.rotation.y -= Time.deltaTime * 30.0f;
//				objeto.eulerAngles.y -= Time.deltaTime  * 30;
			}
			//clon.transform = objeto;
		}


	
	}


	void OnGUI(){

		if (inventario) {
			if (GUI.Button (new Rect (Screen.width / 4, Screen.height / 2, Screen.width/5, 50), "Casa")) {
				inventario = false;
				print ("Pulsado casa");
				clon = 	(GameObject)Instantiate (Resources.Load("Casa"));
				altura = 2.6f;
				//objeto = clon.transform;
			}


			if (GUI.Button (new Rect (2*Screen.width/4, Screen.height / 2, Screen.width/5, 50), "Nada")) {
				print ("Pulsado nada");
				inventario = false;
				//objeto = null;
				clon = null;
			}

		}
	}
}
