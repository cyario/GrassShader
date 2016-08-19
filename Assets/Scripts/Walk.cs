using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour
{
	void Update ()
	{
		if ( Input.GetKey(KeyCode.UpArrow) ) {
			this.transform.position += this.transform.forward;
		}
		else if ( Input.GetKey(KeyCode.DownArrow) ) {
			this.transform.position += -this.transform.forward;
		}
		else if ( Input.GetKey(KeyCode.RightArrow) ) {
			transform.Rotate(0, 3, 0);
		}
		else if ( Input.GetKey(KeyCode.LeftArrow) ) {
			transform.Rotate(0, -3, 0);
		}
	}
}