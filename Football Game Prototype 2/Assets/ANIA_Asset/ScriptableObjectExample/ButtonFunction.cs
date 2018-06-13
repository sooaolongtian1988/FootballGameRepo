using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour {

	public DataForManipulate ggg;
	public DataForManipulate fff;

	public void SetData(){
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
		
	
	}

}
