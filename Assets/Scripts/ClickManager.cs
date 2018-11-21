using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour {

    public TextMeshProUGUI weckerName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleName()
    {
        weckerName.enabled = !weckerName.enabled;
    }

}
