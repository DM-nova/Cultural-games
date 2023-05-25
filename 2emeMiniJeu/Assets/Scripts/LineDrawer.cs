using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    public GameObject linePrefab;
    public LayerMask CantDrawOverLayer;
    int CantDrawOverLayerIndex;

    [Space(30f)]
     public Gradient lineColor;
     public float linePointsMinDistance;
     public float lineWidth;

     LineV2 currentLine;

     Camera cam;

    void Start()
    {   
        cam=Camera.main;
        CantDrawOverLayerIndex =LayerMask.NameToLayer("CantDrawOver");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
           BeginDraw();
        if(currentLine !=null)
           Draw();
        if(Input.GetMouseButtonUp(0))
           EndDraw();

    }

    void BeginDraw()
    {
        currentLine = Instantiate(linePrefab, this.transform).GetComponent<LineV2>();
        currentLine.UsePhysics(false);
        currentLine.SetLineColor(lineColor);
        currentLine.SetPointsMinDistance(linePointsMinDistance);
        currentLine.SetLineWidth(lineWidth);
    }
    void Draw()
    {
        Vector2 mousePosition =cam.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.CircleCast(mousePosition, lineWidth /3f , Vector2.zero, 1f, CantDrawOverLayer);
        Debug.Log(hit.transform.name);
        if(hit)
        //EndDraw();
        currentLine.AddPoint(mousePosition);
        else
        //currentLine.AddPoint(mousePosition);
        EndDraw();
    }
    void EndDraw()
    {
        if(currentLine !=null){
            if(currentLine.pointsCount<2){
                Destroy(currentLine.gameObject);
            }else{
                currentLine.gameObject.layer=CantDrawOverLayerIndex;
                currentLine.UsePhysics(true);
                currentLine=null;
            }
        }
    }

    public void DestroyAll(){
        for (int i = 0; i< this.transform.childCount; i++)
              {
                  Destroy(this.transform.GetChild(i).gameObject);
              }
    }
}
