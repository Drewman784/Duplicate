using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DupliScript: MonoBehaviour
{

    public GameObject Player;

    //Duplicate Script
    void OnTriggerEnter2D (Collider2D other)
    {
        GameObject duplicate = Instantiate(Player, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, -90)));
        duplicate.GetComponent<Rigidbody2D>();
    }
}