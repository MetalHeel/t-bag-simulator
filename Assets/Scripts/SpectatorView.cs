using UnityEngine;


public class SpectatorView : MonoBehaviour
{
	private const float moveSpeed = 0.1f;
	private const float lookSpeed = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	void Update()
	{
		// Forward/Back
		if (Input.GetKey(KeyCode.W))
			transform.position = transform.position + transform.forward * moveSpeed;
		if (Input.GetKey(KeyCode.S))
			transform.position = transform.position - transform.forward * moveSpeed;

		// Left/Right
		if (Input.GetKey(KeyCode.A))
			transform.position = transform.position - transform.right * moveSpeed;
		if (Input.GetKey(KeyCode.D))
			transform.position = transform.position + transform.right * moveSpeed;

		// Up/Down
		if (Input.GetKey(KeyCode.Space))
			transform.position = transform.position + new Vector3(0, moveSpeed, 0);
		if (Input.GetKey(KeyCode.LeftControl))
			transform.position = transform.position - new Vector3(0, moveSpeed, 0);

		// Look
		if (Input.GetMouseButton(0))
		{
			yaw += lookSpeed * Input.GetAxis("Mouse X");
			pitch -= lookSpeed * Input.GetAxis("Mouse Y");

			transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
		}
	}
}