using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour
{

		public int maxSpace;
		public int maxPlatform;
		public int novSpace;
		public int novPlatform;
		public bool Block;
		
		public GameObject space_GO;
		
		public float x;

		// Use this for initialization
		void Start ()
		{		
				for (int i = 0; i < 100; i++) {
			
				
				
						if (Random.Range (0, 100) < 50) {
								Block = false;
								//novPlatform += 1;
						} else {
								Block = true;
								novSpace += 1;
						}
						if (Block) {
								novSpace = 0;
						}
//						Debug.Log (space);
						if (maxSpace == novSpace) {
								Block = true;
								novSpace = 0;
						}
						
//					
						x += 3.5f;
						if (Block) {
								Instantiate (space_GO, new Vector3 (x, 0, 0), new Quaternion (0, 0, 0, 0));
						}
						Debug.Log (Block);
				}
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				
	
		}
	
	
}
