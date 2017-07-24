using UnityEngine;


public class SpectatorView : MonoBehaviour
{
	private const float moveSpeed = 0.1f;

	private Vector3 startMousePos = Vector3.zero;

	void Update()
	{
		Vector3 pos = transform.position;

		// Forward/Back.
		if (Input.GetKey(KeyCode.W))
			pos.z += moveSpeed;
		if (Input.GetKey(KeyCode.S))
			pos.z -= moveSpeed;

		// Left/Right.
		if (Input.GetKey(KeyCode.A))
			pos.x -= moveSpeed;
		if (Input.GetKey(KeyCode.D))
			pos.x += moveSpeed;

		// Up/Down
		if (Input.GetKey(KeyCode.Space))
			pos.y += moveSpeed;
		if (Input.GetKey(KeyCode.LeftControl))
			pos.y -= moveSpeed;

		if(Input.GetMouseButton(0))
		{

		}

		transform.position = pos;
	}

	void OnMouseDown()
	{

	}
}