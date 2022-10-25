using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {

	public System.Action onDieClick;

	public Image diceImage;
	public Sprite[] sides;
	public Image lockImage;

	protected bool picked;
	protected bool locked;


	public virtual void Setup() {
		picked = false;
		locked = false;
		diceImage.enabled = true;
		lockImage.enabled = false;
		diceImage.sprite = sides[0];
		Color c = diceImage.color;
		c.a = 1f;
		diceImage.color = c;
	}

	public virtual void SetSide(int side) {
		diceImage.sprite = sides[side];
	}

	public void TogglePick() {
		picked = !picked;
		Color c = diceImage.color;
		c.a = (picked) ? 0.25f : 1f;
		diceImage.color = c;
	}

	public virtual void Roll(bool rollPicked) {
		if (!locked) {
			if (rollPicked || !picked) {
				SetSide(XorRandom.GetInt(0, 6));
				if (picked)
					TogglePick();
			}
		}
	}

	public void SetLock(bool locked) {
		this.locked = locked;
		lockImage.enabled = locked;
	}

	public virtual void ToggleLock() {
		locked = !locked;
		diceImage.enabled = !locked;
		lockImage.enabled = locked;
	}

	public void ClickDie() {
		onDieClick?.Invoke();
	}
}
