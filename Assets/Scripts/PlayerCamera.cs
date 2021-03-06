﻿using UnityEngine;


class PlayerCamera : MonoBehaviour
{
	public GameObject Player = null;

	private Vector3 offset;

	void Start()
	{
		offset = transform.position - Player.transform.position;
	}

	void LateUpdate()
	{
		transform.position = Player.transform.position + offset;
	}
}
