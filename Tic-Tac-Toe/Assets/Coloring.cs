using UnityEngine;

public class Coloring : MonoBehaviour
{
    public bool is_colored = false;
    public bool is_red = false;
    public bool is_blue = false;
    private string color = "black";

    public string GetColor() {
        return this.color;
    }

    public void SetColor(string color) {
        this.color = color;
    }
}
