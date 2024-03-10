using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float moveSpeed = 1;
    public Vector3 mouPos;
    public float minX = -9f;
    public float maxX = 8.7f;
    public float minY = -3.28f;
    public float maxY = 3.14f;
    // Start is called before the first frame update
    void Start()
    {
        mouPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            mouPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            mouPos = new Vector3(Mathf.Clamp(mouPos.x,minX,maxX),Mathf.Clamp(mouPos.y,minY,maxY),0);


        
        }
            transform.position = Vector3.Lerp(transform.position,mouPos , moveSpeed*Time.deltaTime);
        }
        
    }

