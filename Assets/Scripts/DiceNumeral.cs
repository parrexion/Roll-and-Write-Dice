using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceNumeral : Dice {

	public TMPro.TextMeshProUGUI valueText;
	public int maxValue;


	public override void Setup() {
		base.Setup();
		valueText.text = maxValue.ToString();
		valueText.enabled = true;
	}

	public override void SetSide(int side) {
		valueText.text = (side + 1).ToString();
	}

	public override void Roll(bool rollPicked) {
		if (!locked) {
			if (rollPicked || !picked) {
				SetSide(XorRandom.GetInt(0, maxValue));
				if (picked)
					TogglePick();
			}
		}
	}

	public override void ToggleLock() {
		base.ToggleLock();
		valueText.enabled = !locked;
	}
}
