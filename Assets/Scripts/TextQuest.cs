using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextQuest : MonoBehaviour
{
    #region Variables

    public Text contentLabel;
    public Text locationLabel;

    public Step startStep;

    [SerializeField]
    private Step currentStep;

    #endregion

    #region Unity lifecycle
    private void Start()
    {
        currentStep = startStep;
        UpdateContentLabel();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MoveToNextStep(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MoveToNextStep(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MoveToNextStep(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MoveToNextStep(3);
        }
    }
    #endregion
    #region Public methods
    #endregion

    #region Private methods

    private void UpdateContentLabel()
    {
        contentLabel.text = currentStep.contentText;
        locationLabel.text = currentStep.locationText;

    }

    private void MoveToNextStep(int stepIndex)
    {
        if (currentStep.nextSteps.Length > stepIndex)
        {
            currentStep = currentStep.nextSteps[stepIndex];
            UpdateContentLabel();
        }
    }

    #endregion
}
