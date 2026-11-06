using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject CardBack;
    [SerializeField] private SceneController controller;

    private int _id;

    // Public getter so SceneController can read the ID
    public int id
    {
        get { return _id; }
    }

    // Called by SceneController to assign the ID and the correct sprite
    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void OnMouseDown()
    {
        if (CardBack.activeSelf && controller.canReveal)
        {
            CardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        CardBack.SetActive(true);
    }
}