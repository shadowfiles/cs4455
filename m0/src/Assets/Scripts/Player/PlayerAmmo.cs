using UnityEngine;
using UnityEngine.UI;

public class PlayerAmmo : MonoBehaviour {
	public int maxAmmo = 30;
	public Slider ammoSlider;
	
	int currentAmmo;

	// Use this for initialization
	void Start () {
		currentAmmo = maxAmmo;
	}

	public bool AddAmmo (int n) {
		bool result = false;
		if (currentAmmo < maxAmmo) {
			currentAmmo += n;
			if (currentAmmo > maxAmmo) {
				currentAmmo = maxAmmo;
			}

			UpdateSlider();

			result = true;
		}
		return result;
	}

	public bool UseAmmo () {
		bool result = false;
		if (HasAmmo ()) {
			currentAmmo--;
			result = true;
			UpdateSlider();
		}
		return result;
	}

	public bool HasAmmo () {
		return currentAmmo > 0;
	}

	void UpdateSlider () {
		ammoSlider.value = currentAmmo;
	}
}
