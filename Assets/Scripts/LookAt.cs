using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
	[SerializeField]
	private Transform target;
	[SerializeField]
	private Camera m_Camera;

	//public float adjustangle;

	// Mono
	void Update()
	{
		//transform.localScale = new Vector3(-0.2F, 0.2f, 0.2f);
		/*
        if (target == null)
			return;
			*/
		m_Camera = Camera.main;

		target = m_Camera.transform;
		transform.LookAt(target);
		//transform.eulerAngles = new Vector3(10, adjustangle, 0);
	}
}
