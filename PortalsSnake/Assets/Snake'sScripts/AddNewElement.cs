using UnityEngine;
using System.Collections;

public class AddNewElement : MonoBehaviour {
	public float PauseTime;
	public float LastTime;
	public GameObject Element;
	public Vector2 FieldParams;
	public int CellSize;
	
	// Use this for initialization
	void Start () {
	LastTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
	if(Time.time-LastTime>=PauseTime)
		{
			LastTime = Time.time;
			float x = Random.Range(-20f,20f);
			float y = Random.Range(-15f,15f);
			Vector3 position = new Vector3(x*CellSize,y*CellSize,1);
			GameObject element = (GameObject)GameObject.Instantiate(Element);
			element.transform.localPosition = position;
		}
	}
}