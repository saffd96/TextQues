using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{
    #region Variables
    [TextArea(15, 50)]
    public string contentText;
    public string locationText;

    public Step[] nextSteps;

    public Sprite sprite;

    #endregion
}
