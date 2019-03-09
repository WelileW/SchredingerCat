using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCounterControl : MonoBehaviour
{
    public Sprite One;
    public Sprite Two;
    public Sprite Three;
    public Sprite Four;
    public Sprite Five;
    public Sprite Six;
    public Sprite Seven;
    public Sprite Eight;
    public Sprite Nine;
    public Sprite Ten;

    private int _score = 0;

    public void SetScore(int score)
    {
        if (_score == score)
            return;

        _score = score;

        switch (_score)
        {
            case 0:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
                break;
            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = One;
                break;
            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Two;
                break;
            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Three;
                break;
            case 4:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Four;
                break;
            case 5:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Five;
                break;
            case 6:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Six;
                break;
            case 7:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Seven;
                break;
            case 8:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Eight;
                break;
            case 9:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Nine;
                break;
            case 10:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Ten;
                break;
            default:
                break;
        }
    }
}
