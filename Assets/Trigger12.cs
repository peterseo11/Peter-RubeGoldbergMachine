using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger12 : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;
    public Camera camera9;
    public Camera camera10;
    public Camera camera11;
    public Camera camera12;
    public Camera camera13;

    void OnTriggerEnter2D(Collider2D other)
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;
        camera8.enabled = false;
        camera9.enabled = false;
        camera10.enabled = false;
        camera11.enabled = false;
        camera12.enabled = false;
        camera13.enabled = true;
    }
    }
