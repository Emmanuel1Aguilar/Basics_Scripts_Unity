using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour {

	public void Jugar()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
	public void Cargar()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
	}
	public void Opciones()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 3);
	}

	}

