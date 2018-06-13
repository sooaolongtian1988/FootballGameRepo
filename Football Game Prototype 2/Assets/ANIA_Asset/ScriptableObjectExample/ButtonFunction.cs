using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour {

	public DataForManipulate savableData;

    public void BuyBall1()
    {
        savableData.ball1 = true;
        print(savableData.ball1);
    }

    public void BuyBall2()
    {
        savableData.ball1 = true;
    }

    public void BuyBall3()
    {
        savableData.ball1 = true;
    }

    public void BuyBall4()
    {
        savableData.ball1 = true;
    }






    /*public void SetData(){
		ggg.myNamess = "sky";
		ggg.agess += 1;
		ggg.heightss += 0.522f;
		ggg.positionss [1].y += 1;
		ggg.positionss [3].x += 1;
	}

	public void SetData2(){
		fff.myNamess = "sky";
		fff.agess += 1;
		fff.heightss += 0.522f;
		fff.positionss [1].y += 1;
		fff.positionss [3].x += 1;
	}



	public void trytry(){
		
	
	}*/

}
