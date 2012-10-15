using System;
using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour
{
    public Settings Settings;
	string widthString = "";
    string heightString = "";

	// Use this for initialization
	void Start () {
		widthString = Settings.FieldCellWidth.ToString();
		heightString = Settings.FieldCellHeight.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
    {
        GUI.Box(new Rect(620, 10, 160, 180), "ChangeSizePanel");
        {
            GUI.Label(new Rect(630, 30, 140, 20), "Width");
		    
            widthString = GUI.TextField(new Rect(630, 55, 140, 20),widthString,2);

            GUI.Label(new Rect(630, 95, 140, 20), "Height");
            heightString = GUI.TextField(new Rect(630, 120, 140, 20),heightString,2);

            if (GUI.Button(new Rect(630, 160, 140, 20), "Resize field"))
            {
                var cellWidth = 0;
                var cellHeight = 0;
                if (!Int32.TryParse(widthString, out cellWidth)||!Int32.TryParse(heightString,out cellHeight))
                {
                   Debug.LogError("data is not number");
                }
                else
                {
                    if (Settings != null) Settings.SetFieldSize(cellWidth,cellHeight);
                }
            }
        }

        GUI.Box(new Rect(620, 200, 160, 60), "AddWallPanel");
        {
            if (GUI.Button(new Rect(630, 230, 140, 20), "Add Wall"))
            {
                return;
            }
        }

        GUI.Box(new Rect(620, 270, 160, 60), "SetStartPostionPanel");
        {
            if (GUI.Button(new Rect(630, 300, 140, 20), "Set Start"))
            {
                return;
            }
        }

        GUI.Box(new Rect(620, 340, 160, 60), "AddPortalPanel");
        {
            if (GUI.Button(new Rect(630, 370, 140, 20), "Add Portal"))
            {
                return;
            }
        }
    }

}
