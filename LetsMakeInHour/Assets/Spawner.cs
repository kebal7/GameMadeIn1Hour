using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using static System.Diagnostics.Debug;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    public float timer = 0;
    public float distance = 7;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer>maxTime)
        {
            GameObject newenemy = Instantiate(enemy);
            newenemy.transform.position = transform.position + new Vector3(Random.Range(-distance, distance), 0, 0);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    public void Update()
    {
        Destroy();
    }

    public void Destroy()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100f));

            Vector3 direction = worldMousePosition - Camera.main.transform.position;

            RaycastHit hit;

            if(Physics.Raycast(Camera.main.transform.position, direction, out hit, 100f))
            {
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.green, 0.5f);

                if(hit.collider.gameObject.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                    Score.score++;

                }
            }

            else
            {
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.red, 0.5f);
            }

        }
    }
}
