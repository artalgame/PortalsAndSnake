using Interfaces.ChangeFieldSizeWatcher;
using UnityEngine;
using System.Collections.Generic;
using Interfaces.RedactorAddObjectsState;

[ExecuteInEditMode]
public class FieldParameters : MonoBehaviour,IChangeFieldSizeListener,IRedactorAddObjectOwner {
	
	
	public IRedactorAddObjectState CurrentState{get;set;}
	
	public Settings SettingsClass;
	public int FieldWidth;
	public int FieldHeight;
	public GameObject Line;
	public List<GameObject> CellLines;
	
	// Use this for initialization
	[ExecuteInEditMode]
	void Start () 
	{
		if(SettingsClass != null)
		{
			SettingsClass.AddNewListener(this);
			DrawField();
		}
	}
	[ExecuteInEditMode]
    void DrawField()
    {
		FieldWidth = SettingsClass.FieldCellWidth*SettingsClass.CellSize;
		FieldHeight = SettingsClass.FieldCellHeight*SettingsClass.CellSize;
		
		transform.localPosition = new Vector3(SettingsClass.FieldX,SettingsClass.FieldY,10);
		transform.localScale = new Vector3(FieldWidth,FieldHeight,1);
		
        DrawCells();
    }

    private void DrawCells()
    {
		if(Line!=null)
		{
			foreach(var line in CellLines)
			{
				GameObject.Destroy(line);
			}
		}
		
		CellLines = new List<GameObject>();
        int i = 0;
		int j = 0;
		int startX = SettingsClass.FieldX-FieldWidth/2;
		int startY = SettingsClass.FieldY-FieldHeight/2;
		while(i<=SettingsClass.FieldCellHeight)
		{
			var pos = new Vector3(SettingsClass.FieldX,i * SettingsClass.CellSize+SettingsClass.FieldOffsetY+startY, 0f);
			var line =(GameObject) Instantiate(Line,pos,Line.transform.rotation);
			line.transform.localScale = new Vector3(FieldWidth,1f,1f);
			i++;
			CellLines.Add(line);
		}
		while(j<=SettingsClass.FieldCellWidth)
		{
			var pos = new Vector3(j * SettingsClass.CellSize+SettingsClass.FieldOffsetX+startX, SettingsClass.FieldY, 0f);
			var line = (GameObject)Instantiate(Line,pos,Line.transform.rotation);
			line.transform.localScale = new Vector3(1f,FieldHeight,1f);
			j++;
			CellLines.Add(line);
		}
    }

    // Update is called once per frame
	void Update () {
	
	}

    public void ListenSizeChanged()
    {
        DrawField();
    }
}
