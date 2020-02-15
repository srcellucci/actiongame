using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseShootRecoil : MonoBehaviour
{
	
	private Vector2 toPushDirection;
	private bool push;
	private Transform transform;
	public float pushStrength;
	
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
		push = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	void FixedUpdate() {
		
	}
	
	void OnMouseDown() {
		push = true;
		//Vector from mouse's world coordinates to player coordinates.
		toPushDirection = position - Camera.ViewportToWorldPoint(Input.MousePosition());
	}
}
