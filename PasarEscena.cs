using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarEscena : MonoBehaviour {


	public void pasar(string pEscena)
	{
		SceneManager.LoadScene(pEscena);
	}
}
