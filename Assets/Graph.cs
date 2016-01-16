using UnityEngine;

public class Graph : MonoBehaviour
{
    // Chagne Expression
    public float Calculate(float x)
    {
        float y = Mathf.Sin(x);
        return y;
    }

    public Vector2[] GenerateGraph(int count, float space)
    {
        var array = new Vector2[count];
        var index = 0;
        for (int i = -count / 2; i < count / 2; i++)
        {
            var posX = i * space;
            var posY = Calculate(posX);
            array[index] = new Vector2(posX, posY);
            index++;
        }

        return array;
    }
}
