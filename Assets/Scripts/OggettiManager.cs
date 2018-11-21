using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OggettiManager : MonoBehaviour {

    public Camera mainCamera;
    public GameObject[] oggetti;
    public TextMeshProUGUI[] nomiOggetti;


	// Use this for initialization
	void Start () {
		for(int i = 0; i < nomiOggetti.Length; i++)
        {
            nomiOggetti[i].enabled = false;
        }
	}

    private void OnMouseDown()
    {
        Debug.Log("ok");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

            if (hit)
            {
                for (int i = 0; i < nomiOggetti.Length; i++)
                {
                    if (nomiOggetti[i].name == hit.collider.name) {
                        nomiOggetti[i].enabled = !nomiOggetti[i].enabled;
                    };
                }
            }
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("mouse down");
        //    for (int i = 0; i < oggetti.Length; i++)
        //    {
        //        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //        PolygonCollider2D coll = oggetti[i].GetComponent<PolygonCollider2D>();
        //        Debug.Log(wp);

        //        if (coll.OverlapPoint(wp))
        //        {
        //            Debug.Log("got it");
        //            nomiOggetti[i].enabled = !nomiOggetti[i].enabled;
        //        }
        //    }
        //}
    }
}
