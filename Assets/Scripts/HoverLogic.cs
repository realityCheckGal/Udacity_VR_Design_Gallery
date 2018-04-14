using UnityEngine;
using System.Collections;

public class HoverLogic : MonoBehaviour
{
	// The initial material of the orb.
	private Material defaultMaterial;

	// The material used to light up the orb.
	public Material lightUpMaterial;


	void Start()
	{
		// Assign the initial material of the orb as the default material.
		defaultMaterial = this.GetComponent<MeshRenderer>().material;
	}
		
	// Called when the orb is clicked.
	// This function can be hooked up in Unity by adding a Pointer Click event trigger to the orb.
	public void OnClick()
	{
        Debug.Log ("Clip = " + this.GetComponent<GvrAudioSource>().clip );
		// Get the GVR audio source component on this country and play the audio.

		this.GetComponent<GvrAudioSource>().Play();
	}

	// Called when the reticle moves over the country.
	// This function can be hooked up in Unity by adding a Pointer Enter event trigger to the object.
	public void OnRollOver()
	{
		// Assign the lightup material to the object.
		this.GetComponent<MeshRenderer>().material = lightUpMaterial;
	}

	// Called when the reticle is moved away from country.
	// This function can be hooked up in Unity by adding a Pointer Exit event trigger to the object.
	public void OnRollOff()
	{
		// Revert to the orb's default material.
		this.GetComponent<MeshRenderer>().material = defaultMaterial; 
	}

}
