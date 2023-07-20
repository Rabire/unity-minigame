using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -2f)
        {
            SceneManager.LoadScene(3);
        }
    }
}