using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour {

    GameObject ball;
    public Transform ballTransform;
    public GameObject[] balls;
    int ballIndex;

    // Use this for initialization
    void Start () {
        ball = balls[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisplayNextBallToRight()
    {

        if (ball.gameObject.name == balls[0].gameObject.name)
        {
            ballIndex = 1;
        }
        else if (ball.gameObject.name == balls[1].gameObject.name)
        {
            ballIndex = 2;
        }
        else if (ball.gameObject.name == balls[2].gameObject.name)
        {
            ballIndex = 3;
        }
        else if (ball.gameObject.name == balls[3].gameObject.name)
        {
            ballIndex = 4;
        }
        else if (ball.gameObject.name == balls[4].gameObject.name)
        {
            ballIndex = 0;
        }

        switch (ballIndex)
            {
                case 1:
                    GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                    ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                    ball.transform.SetParent(ballTransform.transform);
                    ball = balls[ballIndex];
                    break;
                case 2:
                    GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                    ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                    ball.transform.SetParent(ballTransform.transform);
                    ball = balls[ballIndex];
                break;
                case 3:
                    GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                    ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                    ball.transform.SetParent(ballTransform.transform);
                    ball = balls[ballIndex];
                break;
                case 4:
                    GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                    ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                    ball.transform.SetParent(ballTransform.transform);
                    ball = balls[ballIndex];
                break;
                case 0:
                    GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                    ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                    ball.transform.SetParent(ballTransform.transform);
                    ball = balls[ballIndex];
                break;

            default:
                 
                    break;
            }
        }

    public void DisplayNextBallToLeft()
    {

        if (ball.gameObject.name == balls[0].gameObject.name)
        {
            ballIndex = 4;
        }
        else if (ball.gameObject.name == balls[4].gameObject.name)
        {
            ballIndex = 3;
        }
        else if (ball.gameObject.name == balls[3].gameObject.name)
        {
            ballIndex = 2;
        }
        else if (ball.gameObject.name == balls[2].gameObject.name)
        {
            ballIndex = 1;
        }
        else if (ball.gameObject.name == balls[1].gameObject.name)
        {
            ballIndex = 0;
        }

        switch (ballIndex)
        {
            case 1:
                GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                ball.transform.SetParent(ballTransform.transform);
                ball = balls[ballIndex];
                break;
            case 2:
                GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                ball.transform.SetParent(ballTransform.transform);
                ball = balls[ballIndex];
                break;
            case 3:
                GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                ball.transform.SetParent(ballTransform.transform);
                ball = balls[ballIndex];
                break;
            case 4:
                GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                ball.transform.SetParent(ballTransform.transform);
                ball = balls[ballIndex];
                break;
            case 0:
                GameObject.Destroy(ballTransform.transform.GetChild(0).gameObject);
                ball = Instantiate(balls[ballIndex], ballTransform.position, Quaternion.identity);
                ball.transform.SetParent(ballTransform.transform);
                ball = balls[ballIndex];
                break;


            default:

                break;
        }
    }





}
//Destroy(transform.GetChild(i).gameObject);

/*public int intelligence = 5;


void Greet()
{
    switch (intelligence)
    {
        case 5:
            print("Why hello there good sir! Let me teach you about Trigonometry!");
            break;
        case 4:
            print("Hello and good day!");
            break;
        case 3:
            print("Whadya want?");
            break;
        case 2:
            print("Grog SMASH!");
            break;
        case 1:
            print("Ulg, glib, Pblblblblb");
            break;
        default:
            print("Incorrect intelligence level.");
            break;
    }
}*/