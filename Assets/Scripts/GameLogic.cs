using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public Material travel_map;
	public Material travel_italy;
	public Material travel_spain;
	public Material travel_germany;
	public Material travel_sanjuan;
	public Material travel_hawaii;
	public Material travel_australia;
	public GameObject destinations;

    public void OnClick(Material country) {

        // Message using rich text.
    	//Debug.Log("<color=red>Fatal error:</color> AssetBundle not found");
    	// Message with a link to an object.
        Debug.Log ("Hello");

		// Turn off the rendering of the geometry of the countries.
		destinations.SetActive(false);

		// Get the GVR audio source component on this object and play the audio.
		//this.GetComponent<GvrAudioSource>().Play();

		// Swith skybox materials to transport user to destination
		RenderSettings.skybox = country;
          

    	//Destroy(this.box);
    	//Instantiate(box, transform.position, Quaternion.Euler(-45f, 0f, 0f));

    }



}
