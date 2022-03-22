using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jeu");
        Debug.Log("clique détecté");
    }

    // Update is called once per frame
    public void Options()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Options");
    }
}
