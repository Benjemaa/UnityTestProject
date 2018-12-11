using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {


    public string cardName;
    public bool faced;



	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
    void Update()
    {
     
    }
   

    public void Flip()
    {
        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
        faced = !faced;
    }
}
