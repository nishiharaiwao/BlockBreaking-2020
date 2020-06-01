using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 20.0f;    //これを追加

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(
            (transform.forward + transform.right) * speed,ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter( Collision collision)
    {
        string yourTag = collision.gameObject.tag;
        if (yourTag == "Block") {
            FindObjectOfType<ScoreManager>().ScoreUp(1);
        } else if (yourTag == "BottomWall") {
            FindObjectOfType<ScoreManager>().LessPlayers();
        }
    }
}

