using UnityEngine;

public class Coloring : MonoBehaviour
{
    private Color color = Color.black;

    public Color GetColor() {
        return this.color;
    }

    public void SetColor(Color color) {
        this.color = color;
    }
}
