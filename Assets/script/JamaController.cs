using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamaController : MonoBehaviour 
{
	public GameOverController GameOverController;
	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Plyer")) {
			hit.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
			GameOverController.ShowGameOverLabel ();
		}
	}
	


}
