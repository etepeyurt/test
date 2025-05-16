using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using static UnityEditor.Searcher.SearcherWindow.Alignment;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public int speed;
    public Rigidbody physics;
    public int count;
    public int objectNumber;
    public Text pointText;
    public Text gameOverText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Debug.Log("ESC Pressed");
        //}

       float horizontal =  Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
        Vector3 vektor = new Vector3(horizontal * speed, 0 , vertical * speed);

        //Debug.Log("horizontal = " + horizontal);
        //Debug.Log("vertical = " + vertical);
        physics.AddForce(vektor);
    }
    void OnTriggerEnter(Collider other)
    {
        count++;
        pointText.text = "Point: " + count;
        other.gameObject.SetActive(false);     
        //Debug.Log("Point: " + count);
        if(count == objectNumber)
        {
           gameOverText.gameObject.SetActive(true);
        }
    }
}