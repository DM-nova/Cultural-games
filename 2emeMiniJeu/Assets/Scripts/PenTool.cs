using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PenTool : MonoBehaviour
{  [Header("Pen Canvas")]
   [ SerializeField] private PenCanvas penCanvas;
    
     [Header("Dots")]
[SerializeField] private GameObject dotPrefab;
[SerializeField] Transform dotParent;


[Header("Lines")]
    [SerializeField] private Transform lineParent;
    [SerializeField] private GameObject linePrefab;
    private LineController currentLine;

    [SerializeField] Image LoopToggle;
    [SerializeField] Sprite loopSprite;
    [SerializeField] Sprite  unloopSprite; 

    // Start is called before the first frame update
    void Start()
    {
        penCanvas.OnPenCanvasLeftClickEvent += AddDot;
        penCanvas.OnPenCanvasRightClickEvent += EndCurrentLine;
    }
    private void EndCurrentLine()
    {
        if (currentLine != null){
            currentLine=null;
        }
    }
    public void ToggleLoop(){
        if(currentLine != null){
            currentLine.ToggleLoop();
            LoopToggle.sprite=(currentLine.isLooped())?unloopSprite : loopSprite;
        }
    }
    private void AddDot()
    {
         if( currentLine == null)
        {
            currentLine =Instantiate(linePrefab,Vector3.zero,Quaternion.identity,lineParent).GetComponent<LineController>();

        }
        DotController dot = Instantiate(dotPrefab,GetMousePosition(), Quaternion.identity,dotParent).GetComponent<DotController>();
       dot.OnDragEvent += MoveDot;

       dot.OnRightClickEvent += RemoveDot;
       //dot.OnLeftClickEvent +=SetCurrentLine;

       currentLine.AddPoint(dot);
    }

    private void RemoveDot(DotController dot)
    {
       LineController line = dot.line;
       line.SplitPointAtIndex(dot.index, out List<DotController> before, out List<DotController>after);

       Destroy(line.gameObject);
       Destroy(dot.gameObject);

       LineController beforeLine =Instantiate(linePrefab, Vector3.zero,Quaternion.identity, lineParent).GetComponent<LineController>();
       for(int i =0;i<before.Count;i++)
       {
        beforeLine.AddPoint(before[i]);
       }
       LineController afterLine =Instantiate(linePrefab, Vector3.zero,Quaternion.identity, lineParent).GetComponent<LineController>();
       for(int i =0;i<after.Count;i++)
       {
        beforeLine.AddPoint(after[i]);
       }
    }

   private void MoveDot(DotController dot)
   {
    dot.transform.position = GetMousePosition();
   }
   

   
    private Vector3 GetMousePosition()
    {
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldMousePosition.z=0;
        return worldMousePosition;
    }
}
