using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineV2 : MonoBehaviour
{   
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public Rigidbody2D rigidBody;

    [HideInInspector] public List<Vector2> points=new List<Vector2>();
    [HideInInspector] public int pointsCount=0;

    float pointMinDistance =0.1f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddPoint(Vector2 newPoint)
    {
       if( pointsCount >=1 && Vector2.Distance(newPoint,GetLastPoint()) < pointMinDistance)
       {
        return;
       }
       points.Add(newPoint);
       pointsCount++;
        
        //line renderer
       lineRenderer.positionCount = pointsCount;
       lineRenderer.SetPosition(pointsCount -1, newPoint);
        
        //edgeCollider
        if(pointsCount >1)
        edgeCollider.points=points.ToArray();


    }
    public Vector2 GetLastPoint()
    {
         return (Vector2)lineRenderer.GetPosition (pointsCount -1);
    }
    public void UsePhysics(bool usePhysics)
    {
       rigidBody.isKinematic=!usePhysics;
    }
    public void SetLineColor(Gradient colorGradient)
    {
       lineRenderer.colorGradient = colorGradient;
    }
    public void SetPointsMinDistance(float distance)
    {
        pointMinDistance=distance;
    }
    public void SetLineWidth (float width)
    {
        lineRenderer.startWidth =width;
        lineRenderer.endWidth =width;

        edgeCollider.edgeRadius =width / 2f;

    }

    

}
