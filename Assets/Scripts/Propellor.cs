using UnityEngine;


class Propellor : MonoBehaviour
{
	private Rigidbody rb;

	public float baseThrust = 0;
	public float thrust = 0;

	private bool hovering = false;
    private bool moving = false;

    private float steady = 0.5f;
    private float tilt = 5.0f;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		rb.AddRelativeForce(transform.up * baseThrust);

		hovering = Input.GetMouseButton(0);
        moving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);

        if (hovering)
			rb.AddRelativeForce(transform.up * thrust);

        if (Input.GetKey(KeyCode.W))
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(tilt, Vector3.right), Time.time * steady);
        if (Input.GetKey(KeyCode.S))
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(-tilt, Vector3.right), Time.time * steady);
        if (Input.GetKey(KeyCode.A))
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(tilt, Vector3.forward), Time.time * steady);
        if (Input.GetKey(KeyCode.D))
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(-tilt, Vector3.forward), Time.time * steady);

        if (!moving)
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.identity, Time.time * steady);
    }
}
