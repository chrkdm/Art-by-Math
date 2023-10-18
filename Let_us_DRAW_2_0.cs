using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Let_us_DRAW_2_0 : MonoBehaviour
{
    // First of all
    private float Y = 0f; // Main function
    public GameObject Point; // Initial object (sprite)
    private int Dots_counter = 0; // Counter of instantiated dots
    private readonly float Sc3 = 0.010f; // Hard density
    private readonly float Sc4 = 0.001f; // Ultra hard density

    private void Start()
    {
        //// ------------------------------ Face (Counter comment starts from 0)
        // 0
        LineA(0, -4, 12, 1, 1, -11.316f, -9.6f);
        LineA(0, -4, 12, -1, 1, 9.6f, 10.219f);
        LineA(0, -2, 24, 1, 3, -9.6f, 0);
        LineA(0, -2, 24, -1, 3, 0, 9.6f);
        Cosine(10, 9, -1, 5.23f, 9);
        // 5
        Cosine(10, 9, -1, -9, -5.23f);
        CurveA(0, -2, -4, 7, 3, -8.5f, -5.5f);
        CurveA(0, -2, -4, -7, 3, 5.5f, 8.5f);
        CurveA(0, 2, -4, 7, 3, -8.5f, -8.111f);
        CurveA(0, 2, -4, 7, 3, -5.93f, -5.5f);
        // 10
        CurveA(0, 2, -4, -7, 3, 5.5f, 5.93f);
        CurveA(0, 2, -4, -7, 3, 8.111f, 8.5f);
        CurveB(0, 3, -1, 7, 5, -9.5f, -7);
        CurveB(0, 3, -1, -7, 5, 7, 9.5f);
        CurveA(0, -2, -1, 7.5f, 2, -9.5f, -9.232f);
        // 15
        CurveA(0, -2, -1, -7.5f, 2, 9.232f, 9.5f);
        CurveB(0.5f, 2, -1, -7, 5, 4.5f, 7);
        CurveB(0.5f, 2, -1, 7, 5, -7, -4.5f);
        CurveC(2, 7, 4, -9, -5);
        CurveC(2, -7, 4, 5, 5.519f);
        // 20
        CurveC(2, -7, 4, 5.554f, 7.5f);
        CurveC(2, -7, 4, 7.61f, 9);
        LineA(0, -2, 4.25f, 1, 1, -5, -4.5f);
        LineA(0, -2, 4.25f, -1, 1, 4.5f, 5);
        LineB(1.5f, -9.873f, -9);
        // 25
        LineB(1.5f, 9, 10);
        LineA(0, -1, 8.5f, 1, 1, -9.863f, -9.5f);
        LineA(0, 1, -8.5f, 1, 1, 9.5f, 10);
        CurveA(0, 1, 1, 9.5f, 1, -9.828f, -9.5f);
        CurveA(0, 1, 1, -9.5f, 1, 9.5f, 10.5f);
        // 30
        LineA(-8.2811f, -1, 0, 1, 1.268f, -9.647f, -9.232f);
        LineA(-8.2811f, 1, 0, 1, 1.268f, 9.232f, 10.5f);
        CurveD(2.5f, -2, 7, 4, -7, -5.93f);
        CurveD(2.5f, -2, -7, 4, 6.04f, 7);
        LineB(5, -7, -6.5f);
        // 35
        CurveA(0, -1, -1, 7, 0.75f, -7.75f, -6.25f);
        CurveA(0, -1, -1, -7, 0.75f, 6.25f, 7.75f);
        CurveA(0, 0.75f, -1, 8.125f, 0.375f, -8.5f, -7.75f);
        CurveA(0, 0.75f, -1, -5.875f, 0.375f, 5.5f, 6.25f);
        CurveB(-10, -1, -1, 0, 4, -2, 2);
        // 40
        LineA(-6.333f, 0.333f, 0.332f, 1, 0.002f, -0.334f, -0.332f);     
        //// -------------------------------------------------------------- Hair
        CurveH(11, -10, 0, 1, -1, 0);
        CurveH(11, 4, 0, 1, -1, 0);
        CurveH(11, -10, 0, 3, -3, 0);
        CurveH(11, 8, 0, 3, -3, 0);
        // 45
        CurveH(11, -10, 0, 2.5f, 0, 2.5f);
        CurveH(11, 6, -1, 1.5f, 1, 2.5f);
        CurveH(7, 4, -2.5f, 1, 2.5f, 3.5f);
        CurveH(7, -5, -2.5f, 1, 2.5f, 3.5f);
        CurveH(11, -9, -2.5f, 2.5f, 2.5f, 5);
        // 50
        CurveH(11, 8, -3, 2, 3, 5);
        CurveH(6, -5, -5, 1, 5.5f, 6);
        CurveH(6, 5, -5, 1, 5, 6);
        LineA(1, 4, -5, 1, 3, 5.5f, 8);
        CurveH(5, -3.5f, -7, 1, 7, 8);
        // 55
        CurveH(11, -9.5f, -7, 2, 7, 9);
        CurveH(6, 5, 3, 2, -5, -3);
        CurveH(6, -5, 4, 1, -5, -3);
        CurveH(10, -9, 4, 3, -7, -4);
        CurveH(10, 11, 1, 6, -7, -4.5f);
        // 60
        CurveH(5, -10, 8, 2, -10, -8);
        CurveH(5, 18, 2, 8, -10, -2);
        CurveH(4, -9, 8, 5, -13, -8);
        CurveH(4, 18, 5, 8, -13, -5);
        CurveH(4, -16, 10, 3, -13, -10);
        // 65
        CurveH(4, 14.5f, 10.5f, 5.5f, -16, -10);
        CurveH(4, 16, 10, 6, -16, -10);
        CurveH(4, -20, 8, 8, -16, -8);
        CurveH(10, 12, 8, 9, -17, -9.739f);
        CurveH(10, 14, 0, 18, -17.921f, 0);
        // 70
        LineC(-17, -7, 10);
        CurveH(4, -11, 17, 1, -17, -16);
        CurveH(-2, -1, 19, 2, -19, -17);
        CurveH(1, -4, 19, 2, -19, -17);
        CurveH(4.5f, 20.5f, 0, 19, -19, 0);
        // 75
        CurveH(4.5f, -20.5f, 8, 11, -19, -18.291f);
        CurveH(4.5f, -20.5f, 8, 11, -18.253f, -8);
        CurveH(5, 16, -2, 10, 2, 12);
        CurveH(5, -12.5f, -9, 3, 9, 12);
        CurveH(5, -12.5f, -9, 5, 9, 14);
        // 80
        CurveH(5, -17, -10, 4, 10, 14);
        CurveH(4, -16, -10, 7, 10, 17);
        CurveH(4, -20, -9, 8, 9, 17);
        CurveH(4, -13, -16, 1, 16, 17);
        CurveH(4, -13, -16, 2.5f, 16, 18.5f);
        // 85
        CurveH(-1, -15, -9, 11, 9, 20);
        CurveH(4, -5, -20, 1.5f, 18.5f, 20);
        CurveH(5, 17, -4, 8, 4, 12);
        CurveH(23, -1, -4, 4, 0, 4);
        LineB(24, 0, 4);
        // 90
        CurveH(4, 20, -4, 13, 4, 17);
        CurveH(4, 18, -11, 7.5f, 10, 18.035f);
        CurveH(-1, 26, 0, 20, 0, 20f);
        // Instantiated dots total
        Debug.Log(Dots_counter);
    }

    // Calculating voids
    private void CurveA(float y0, float yM, float multi, float inv_x0, float xM, float x_min, float x_max)
    {
        for (float X = x_min; X < x_max; X += Sc3)
        {
            Y = y0 + yM * Mathf.Sqrt(1 + multi * Mathf.Pow(((X + inv_x0) / xM), 2));
            Draw(X, Y);
        }
        Y = y0 + yM * Mathf.Sqrt(1 + multi * Mathf.Pow(((x_max + inv_x0) / xM), 2));
        Draw(x_max, Y);
    }
    private void CurveB(float y0, float yM, float multi, float inv_x0, float xM, float x_min, float x_max)
    {
        for (float X = x_min; X < x_max; X += Sc3)
        {
            Y = y0 + yM * Mathf.Sqrt(0.25f + multi * (Mathf.Pow(((X + inv_x0) / xM), 2)));
            Draw(X, Y);
        }
        Y = y0 + yM * Mathf.Sqrt(0.25f + multi * (Mathf.Pow(((x_max + inv_x0) / xM), 2)));
        Draw(x_max, Y);
    }
    private void CurveC(float M, float inv_x0, float div, float x_min, float x_max)
    {
        for (float X = x_min; X < x_max; X += Sc3)
        {
            Y = M * (1 - Mathf.Pow(((X + inv_x0) / div), 2));
            Draw(X, Y);
        }
        Y = M * (1 - Mathf.Pow(((x_max + inv_x0) / div), 2));
        Draw(x_max, Y);
    }
    private void CurveD(float A, float M, float inv_x0, float div, float x_min, float x_max)
    {
        for (float X = x_min; X < x_max; X += Sc3)
        {
            Y = A + M * Mathf.Pow(((X + inv_x0) / div), 2);
            Draw(X, Y);
        }
        Y = A + M * Mathf.Pow(((x_max + inv_x0) / div), 2);
        Draw(x_max, Y);
    }
    private void CurveH(float y0, float yM, float inv_x0, float xM, float x_min, float x_max)
    {
        float P1, P2;
        P1 = x_min + (Mathf.Abs(x_max - x_min) / 10);
        P2 = x_max - (Mathf.Abs(x_max - x_min) / 10);

        for (float X = x_min; X < P1; X += Sc4)
        {
            Y = y0 + yM * Mathf.Sqrt(1 - Mathf.Pow(((X + inv_x0) / xM), 2));
            Draw(X, Y);
        }
        Y = y0 + yM * Mathf.Sqrt(1 - Mathf.Pow(((P1 + inv_x0) / xM), 2));
        Draw(P1, Y);
        
        for (float X = P1; X < P2; X += Sc3)
        {
            Y = y0 + yM * Mathf.Sqrt(1 - Mathf.Pow(((X + inv_x0) / xM), 2));
            Draw(X, Y);
        }
        Y = y0 + yM * Mathf.Sqrt(1 - Mathf.Pow(((P2 + inv_x0) / xM), 2));
        Draw(P2, Y);

        for (float X = P2; X < x_max; X += Sc4)
        {
            Y = y0 + yM * Mathf.Sqrt(1 - Mathf.Pow(((X + inv_x0) / xM), 2));
            Draw(X, Y);
        }
        Y = y0 + yM * Mathf.Sqrt(1 - Mathf.Pow(((x_max + inv_x0) / xM), 2));
        Draw(x_max, Y);
    }

    private void LineA(float A, float multi, float B, float X_sign, float div, float x_min, float x_max)
    {
        for (float X = x_min; X < x_max; X += Sc3)
        {
            Y = A + multi * ((B + X_sign * X) / div);
            Draw(X, Y);
        }
        Y = A + multi * ((B + X_sign * x_max) / div);
        Draw(x_max, Y);
    }
    private void LineB(float the_y, float x_min, float x_max)
    {
        Y = the_y;
        for (float X = x_min; X < x_max; X += Sc3)
        {
            Draw(X, Y);
        }     
        Draw(x_max, Y);
    }
    private void LineC(float the_x, float y_min, float y_max)
    {
        float X = the_x;
        for (float Y = y_min; Y < y_max; Y += Sc3)
        {
            Draw(X, Y);
        }
        Draw(X, y_max);
    }

    private void Cosine(float M, float div, float A, float x_min, float x_max)
    {
        for (float X = x_min; X < x_max; X += Sc3)
        {
            Y = M * (Mathf.Cos((Mathf.PI * X) / div) + A);
            Draw(X, Y);
        }
        Y = M * (Mathf.Cos((Mathf.PI * x_max) / div) + A);
    }
    
    // Main void
    private void Draw(float x, float y)
    {
        Instantiate(Point, new Vector3(x, y, 0), Quaternion.identity);
        Dots_counter++;
    }

    /* Variables description
    
    y0      "Y" of curve's core
    inv_x0  inverted "X" of curve's core
    óM      distance between "y0" and max Y of ellipse
    xM      distance between "inv_x0" and max X of ellipse
    multi   multiplier of plot width (> is narrower, < is wider)
    M       multiplier of plot height (> is higher, < is lower)
    A       additional value of adjusting the "Y" of curve's core
    x_min   smallest X
    x_max   biggest X
    y_min   smallest Y
    y_max   biggest Y
    the_y   just Y for "Line B" void
    the_x   just X for "Line C" void
    div     value of the divider in the function
    X_sign  minus of plus before X

     */
}
