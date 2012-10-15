using System.Collections.Generic;
using Interfaces.ChangeFieldSizeWatcher;
using UnityEngine;

public class Settings : MonoBehaviour,IChangeFieldSizeSender {
	
	public int ScreenWidth = 800;
	public int ScreenHeight = 600;
	public int CellSize = 20;
	public int FieldOffsetX = 10;
	public int FieldOffsetY = 10;
	public int FieldCellWidth = 30;
	public int FieldCellHeight = 30;
	public int FieldX = 300;
	public int FieldY = 300;
	public bool IsFullScreen = false;
    public int MaxFieldCellWidth = 30;
    public int MaxFieldCellHeight = 30;

    public List<IChangeFieldSizeListener> ChangeFieldSizeListeners = new List<IChangeFieldSizeListener>(); 

	// Use this for initialization
	void Start () 
    {
	    Screen.SetResolution(ScreenWidth,ScreenHeight,IsFullScreen);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetFieldSize(int cellWidth, int cellHeight)
    {
        if ((cellWidth <= 0) || (cellHeight <= 0)) return;
        if ((cellWidth > MaxFieldCellWidth) || (cellHeight > MaxFieldCellHeight)) return;

        FieldCellWidth = cellWidth;
        FieldCellHeight = cellHeight;
        SendSizeChanged();
    }

    public void AddNewListener(IChangeFieldSizeListener listener)
    {
        if(listener != null)
        {
            ChangeFieldSizeListeners.Add(listener);
        }
    }

    public void RemoveListener(IChangeFieldSizeListener listener)
    {
        if(listener != null)
        {
            ChangeFieldSizeListeners.Remove(listener);
        }
    }

    public void SendSizeChanged()
    {
        foreach (var changeFieldSizeListener in ChangeFieldSizeListeners)
        {
            changeFieldSizeListener.ListenSizeChanged();
        }
    }
}
