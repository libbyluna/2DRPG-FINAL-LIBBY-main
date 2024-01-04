
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairways : Collidable

{
    public int sceneBuildIndex;


    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}