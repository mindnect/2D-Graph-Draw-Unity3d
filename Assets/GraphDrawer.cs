using UnityEngine;

public class GraphDrawer : MonoBehaviour
{
    public Graph TargetGraph;

    [Range(0, 1000)]
    public int Count;

    [Range(0, 10)]
    public float Spacing;

    public void Start()
    {
        TargetGraph = GetComponent<Graph>();
    }

    public void OnDrawGizmos()
    {
        if (Count % 2 != 0)
        {
            Count++;
        }
        if (TargetGraph != null)
        {
            TargetGraph = GetComponent<Graph>();
            var array = TargetGraph.GenerateGraph(Count, Spacing);

            // Draw Line
            for (int i = 0; i < Count - 1; i++)
            {
                Gizmos.color = Color.white;
                Gizmos.DrawLine(array[i], array[i + 1]);

            }

            // Draw Vertex
            for (int i = 0; i < Count; i++)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawCube(array[i], new Vector3(0.1f, 0.1f, 0.1f));
            }
        }

    }

}
