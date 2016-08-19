using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {

	void Update ()
	{
		this.transform.LookAt( Camera.main.transform );
		this.transform.rotation =  Quaternion.Euler(this.transform.rotation.eulerAngles.x+90, this.transform.rotation.eulerAngles.y, this.transform.rotation.eulerAngles.z);
	}
}
