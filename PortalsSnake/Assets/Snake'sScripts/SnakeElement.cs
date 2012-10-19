using UnityEngine;
using System.Collections;

public class SnakeElement{
	public GameObject Element{get;set;}
	public Vector3 Direction{get;set;}
	public Vector3 TargetPoint{get;set;}
	public float Speed{get;set;}
	
	public void UpdateDirection(Vector3 direction)
	{
		Direction = direction;
	}
	
	public void UpdateElement()
	{
		Element.transform.localPosition+=Direction*Speed*Time.fixedDeltaTime;
	}
	public void Update(float speed, Vector3 target,Vector3 direction)
	{
		//var dist = Vector3.Distance(Element.transform.localPosition,TargetPoint);
		//if(dist<=0.0001)
		//{
			Speed = speed;
			TargetPoint = target;
			Direction = direction;
		//}
	}	
	
	public void UpdatePosition()
	{
		Element.transform.localPosition = TargetPoint;
	}
}
