using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public Texture2D cursorTexture1;
    public Texture2D cursorTexture2;
    private Vector2 cursorHotspot;

    void Start()
    {
        cursorHotspot = new Vector2(cursorTexture1.width / 2, cursorTexture1.height / 2);
        Cursor.SetCursor(cursorTexture1, cursorHotspot, CursorMode.Auto);
    }

    void Update()
    {
        Vector3 currentMouse = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(currentMouse);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
        Debug.DrawLine(ray.origin, hit.point);

        if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(cursorTexture1, cursorHotspot, CursorMode.Auto);
        }/*
        else if (Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(cursorTexture1, cursorHotspot, CursorMode.Auto);
        }*/
    }

    public void OverButton()
    {
        Cursor.SetCursor(cursorTexture2, cursorHotspot, CursorMode.Auto);
    }

    public void ExitButton()
    {
        Cursor.SetCursor(cursorTexture1, cursorHotspot, CursorMode.Auto);
    }
}
