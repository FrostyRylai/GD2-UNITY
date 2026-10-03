using UnityEngine;
using UnityEngine.InputSystem;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    Transform playerTrans;

    MeshRenderer obstacleRenderer;
    MeshRenderer playerRenderer;

    int hitCount;
    bool checkCollision;

    void Start()
    {
        obstacleRenderer = GetComponent<MeshRenderer>();
        playerRenderer = playerTrans.GetComponent<MeshRenderer>();

        hitCount = 3;
        checkCollision = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (obstacleRenderer.bounds.Intersects(playerRenderer.bounds))
        {
            if (!checkCollision)
            {
                checkCollision = true;

                hitCount = hitCount - 1;

                int randomColor = Random.Range(0, 3);

                if (randomColor == 0)
                {
                    obstacleRenderer.material.color = Color.red;
                }

                if (randomColor == 1)
                {
                    obstacleRenderer.material.color = Color.blue;
                }

                if (randomColor == 2)
                {
                    obstacleRenderer.material.color = Color.green;
                }

                if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
                {
                    playerTrans.Translate(0, 0, 1f);
                }
                else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
                {
                    playerTrans.Translate(0, 0, -1f);
                }
                else if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
                {
                    playerTrans.Translate(-1f, 0, 0);
                }
                else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
                {
                    playerTrans.Translate(1f, 0, 0);    
                }

                if (hitCount <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
        else
        {
            checkCollision = false;
        }
    }
}