using UnityEngine;

public class Collecting : MonoBehaviour
{

    public WinChecker winChecker;
    public movement mv;
    public Coloring coloring;
    private bool collected = false;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "item" && collected == false)
        {
            collected = true;
            Destroy(other.gameObject);
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "point")
        {
            if (collected)
            {
                GameObject collidingObject1 = collision.collider.gameObject;
                Coloring coloring1 = collidingObject1.GetComponent<Coloring>();

                if (coloring1.GetColor() == Color.black)
                { 
                    if (mv.playerIndex == 1)
                    {
                        GameObject collidingObject = collision.collider.gameObject;
                        collidingObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                        collected = false;
                        Coloring coloring = collidingObject.GetComponent<Coloring>();
                        coloring.SetColor(Color.blue);
                        winChecker.CheckWin();

                    }
                    else
                    {
                        GameObject collidingObject = collision.collider.gameObject;
                        collision.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                        collected = false;
                        Coloring coloring = collidingObject.GetComponent<Coloring>();
                        coloring.SetColor(Color.red);
                        winChecker.CheckWin();

                    }
                }

            }
        }
    }
}
