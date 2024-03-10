using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfController : MonoBehaviour
{
    public GameObject Boom;
    public float minBoomtime = 2;
    public float maxBoomtime = 4;
    private float boomTime = 0;
    private float LastBoomTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateBoomTime();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= LastBoomTime + boomTime)
        {
            ThroughBoom();
        }
        
    }
    void UpdateBoomTime()
    {

		LastBoomTime = Time.time;
		boomTime = Random.Range(minBoomtime, maxBoomtime + 1);
	}

    void ThroughBoom()
    {
           Instantiate(Boom,transform.position, Quaternion.identity);

        UpdateBoomTime();

    }
}
