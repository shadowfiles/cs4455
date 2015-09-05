using UnityEngine;
using UnityEngine.UI;

public class PlayerAmmo : MonoBehaviour {

	
	public int maxAmmo = 20;
	public Slider ammoSlider;
	int currentAmmo;


	// Use this for initialization
	void Start () {
		currentAmmo = maxAmmo;
	}

	public bool HasAmmo () {
		return currentAmmo > 0;
	}


	public bool AddAmmo (int n) {
		bool result = false;
		if (currentAmmo < maxAmmo) 
		{
			currentAmmo += n;
			if (currentAmmo > maxAmmo)
			{
				currentAmmo = maxAmmo;
			}
			ammoSlider.value = currentAmmo;
			result = true;
		}
		return result;
	}

	public bool UseAmmo () {
		bool result = false;
		if (HasAmmo ()) 
		{
			currentAmmo -= 1;
			ammoSlider.value = currentAmmo;
			result = true;
		}
		return result;
	}

}
