using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindWave : MonoBehaviour
{
    private Vector3 initialPoint;

    private float restart_timer;
    public float restart_time;
    public float wave_speed;


    // Start is called before the first frame update
    void Start()
    {
        initialPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        restart_timer += Time.deltaTime;
        transform.position += transform.forward * Time.deltaTime * wave_speed;
        if (restart_timer > restart_time) {
            transform.position = initialPoint;
            restart_timer -= restart_time;
        }

    }





}
