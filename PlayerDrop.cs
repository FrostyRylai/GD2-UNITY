using Unity.VisualScripting;
using UnityEngine;

public class PlayerDrop : MonoBehaviour
{
    [SerializeField]
    MeshRenderer stageRenderer;
    MeshRenderer playerRenderer;
    bool checkCollision;
    Transform playerTrans;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRenderer = GetComponent<MeshRenderer>();
        checkCollision = false;
        playerTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRenderer.bounds.Intersects(stageRenderer.bounds))
        {
            checkCollision = true;
        }
        else
        {
            checkCollision = false;
        }

        if (!checkCollision)
        {
            playerTrans.Translate(0, -.02f, 0);
        }
    }

    public bool GetCollision()
    {
        return checkCollision;
    }
}