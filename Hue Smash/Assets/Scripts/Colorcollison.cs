using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colorcollison : MonoBehaviour
{
    Renderer Sphere;
    Renderer test;
    public GameObject GameOverPan;

    // Start is called before the first frame update
    void Start()
    {
        Sphere = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Smash")
        {
            test = col.gameObject.GetComponent<Renderer>();

            if(test.material.name != Sphere.material.name)
            {
                Debug.Log("OH NO");
                gameover();
            }
        }
        if(col.gameObject.tag == "ded")
        {
            gameover();
        }
    }

    void gameover()
    {
        GameOverPan.SetActive(true);
        gameObject.SetActive(false);
    }
}
