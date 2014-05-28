using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetAxis ("Horizontal") < 0) {
						
		
				}
		
		
		}
		
		void OnGUI ()
		{
		
				if (GUILayout.Button ("1")) {
						transform.position = transform.position + new Vector3 (3.4f, 0, 0);
				}
				if (GUILayout.Button ("2")) {
						transform.position = transform.position + new Vector3 (3.4f * 2, 0, 0);
				}
		
		}
		
}
