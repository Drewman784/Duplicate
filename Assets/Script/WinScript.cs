using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript: MonoBehaviour
{
    public string Scenename;

    //call if level must be changed.
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(Scenename);
    }
}