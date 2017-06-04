using UnityEngine;
using System.Collections;

public class CenterOfMass : MonoBehaviour
{
	public GameObject vehicleCenterOfMass;
	//

	//
	void Start ()
	{
        transform.GetComponent<Rigidbody>().centerOfMass = vehicleCenterOfMass.transform.localPosition;
	}
}
