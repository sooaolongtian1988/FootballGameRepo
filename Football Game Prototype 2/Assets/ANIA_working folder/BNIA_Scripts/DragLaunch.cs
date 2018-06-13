using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragLaunch : MonoBehaviour
{
    public Slider heightSlider;
    public Slider curveSlider;
    float startTime, endTime;

    public Ball ball;

    Vector3 dragStart, dragEnd;
    public Rigidbody ballRB;

    bool curving = true;

    // Use this for initialization
    void Start()
    {
        ball = GetComponent<Ball>();
        ballRB = GetComponent<Rigidbody>();
    }

    public void DragStart()
    {
        dragStart = Input.mousePosition;
        startTime = Time.time;
    }

    public void DragEnd()
    {
        dragEnd = Input.mousePosition;
        endTime = Time.time;

        float dragDuration = endTime - startTime;

        float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
        float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

        Vector3 launchVelocity = (new Vector3(launchSpeedX, launchSpeedZ / heightSlider.value, launchSpeedZ))/50;
        ball.Launch(launchVelocity);
        StartCoroutine(BallCurve());

    }

    public void StopCurve() {
        curving = false;
    }


    IEnumerator BallCurve()
    {

        float timer = 0;
        float curveTime = 1;
        while (timer < curveTime)
        {
            timer += Time.deltaTime;
            ballRB.AddForce(transform.right * curveSlider.value);
            print(timer);

             if (timer >= Time.deltaTime)
             {
                ballRB.AddForce(transform.right * -curveSlider.value);
             }

            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}



/*  IEnumerator MyCoroutine()
  {
      bool complete = false;
      while (!complete)
      {
          //Do some repetitive task
          //When done set complete to true
          //Then return control after each step
          yield return null;
      }
  }*/
