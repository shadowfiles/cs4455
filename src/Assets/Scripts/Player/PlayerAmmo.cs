using UnityEngine;
using UnityEngine.UI;

public class PlayerAmmo : MonoBehaviour {
<<<<<<< HEAD

	
	public int maxAmmo = 20;
	public Slider ammoSlider;
	int currentAmmo;


=======
	public int maxAmmo = 30;
	public Slider ammoSlider;
	
	int currentAmmo;

>>>>>>> gh-pages
	// Use this for initialization
	void Start () {
		currentAmmo = maxAmmo;
	}

<<<<<<< HEAD
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
=======
	public bool AddAmmo (int n) {
		bool result = false;
		if (currentAmmo < maxAmmo) {
			currentAmmo += n;
			if (currentAmmo > maxAmmo) {
				currentAmmo = maxAmmo;
			}

			UpdateSlider();

>>>>>>> gh-pages
			result = true;
		}
		return result;
	}

	public bool UseAmmo () {
		bool result = false;
<<<<<<< HEAD
		if (HasAmmo ()) 
		{
			currentAmmo -= 1;
			ammoSlider.value = currentAmmo;
			result = true;
=======
		if (HasAmmo ()) {
			currentAmmo--;
			result = true;
			UpdateSlider();
>>>>>>> gh-pages
		}
		return result;
	}

<<<<<<< HEAD
=======
	public bool HasAmmo () {
		return currentAmmo > 0;
	}

	void UpdateSlider () {
		ammoSlider.value = currentAmmo;
	}
>>>>>>> gh-pages
}
