using UnityEngine;
using System.Collections;

public class NumberView : MonoBehaviour
{
    const float MarginU = 0.1f;
 
    public void SetData(int number)
    {
        number %= 10;

        renderer.material.SetTextureOffset("_MainTex", new Vector2(MarginU * number, 0));
    }
}
