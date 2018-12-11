using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    public float timePerGame;
    public GameObject [] cards;

	// Use this for initialization
	void Start () {
        Vector3 position0 = new Vector3(-12,-12,-2); 
		foreach(GameObject obj in cards){
            Instantiate(obj ,  position0, Quaternion.identity);
            position0.x += 6;
        }
        position0.x = -12;
        position0.y += 6;
        foreach (GameObject obj in cards)
        {
            Instantiate(obj, position0, Quaternion.identity);
            position0.x += 6;
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){ // if left button pressed...
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast(ray, out hit)){
           // the object identified by hit.transform was clicked
           // do whatever you want
             if (hit.transform != null){
                 Debug.Log(hit.transform.gameObject.name);
                 Card card;
                 if (card = hit.transform.GetComponent<Card>())
                 {
                     card.Flip();
                 }
             }

            }
        }
    }
	
}
