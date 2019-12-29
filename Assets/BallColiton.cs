using UnityEngine;
public class BallColiton : MonoBehaviour{
public BallControll ctrl ;
public NumScript NumCTR;
public num2S NumCTR2;
public NumScript NumCTR3;
public LastLineS Winner;
int y =0;
 void OnCollisionEnter(Collision col){


 	/*if(col.collider.tag=="num")
 	{
			y++;													
	  NumCTR.transform.position =new Vector3(25, 10, 10);


	}*/
	
	switch (col.collider.tag) {

    case "num":

	  NumCTR.transform.position =new Vector3(25, 10, 10);
	   y++;	
     break;

      case "num2": // statement sequence
      NumCTR2.transform.position =new Vector3(25, 10, 10);
     break;


      case "num3": // statement sequence
      NumCTR3.transform.position =new Vector3(25, 10, 10);
     break;


// default statement sequence
}
  if(y>=3){
			Winner.GetComponent<Rigidbody>().mass=1;
			Winner.transform.position = new Vector3(-25, 30, 1027);
			Debug.Log("tru");

	}

	/*OnCollisionEnter End */}


}
