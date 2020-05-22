using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public spawnpoint points;

    private void OnEnable()
    {
        int rand = Random.Range(0, 3);
        float xf;
        float yf;
        uint x;
        uint y;

        (xf, yf) = (points.coordonates[rand].x, points.coordonates[rand].y);

        (x, y) = ((uint)xf, (uint)yf);



    }
}
