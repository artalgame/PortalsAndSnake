using UnityEngine;
using System.Collections;

public class Head : MonoBehaviour {
	public SnakeMoving snake;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) 
	{
		Element element = (Element)other.gameObject.GetComponent(typeof(Element));
		if(element != null)
		{
			if(!element.IsInSnake)
			{
				snake.AddElement(other.gameObject);
				element.IsInSnake = true;
			}
		}
	}
}
