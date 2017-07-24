using UnityEngine;


class Propellor : MonoBehaviour
{
	private Rigidbody rb;

	public float baseThrust;
	public float thrust;

	bool hover = false;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		rb.AddForce(transform.up * baseThrust);

		hover = Input.GetMouseButton(0);

		if (hover)
			rb.AddForce(transform.up * thrust);
	}
}
