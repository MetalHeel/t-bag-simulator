using UnityEngine;


class Propellor : MonoBehaviour
{
	private Rigidbody rb;
	public float thrust = 0;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		rb.AddForce(transform.up * thrust);
	}
}
