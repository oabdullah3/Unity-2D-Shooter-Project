using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class inherits for the UIelement class and handles updating the score display
/// </summary>
/// 
public class LivesLeftDisplay : UIelement
{
  
    [Tooltip("The text UI to use for display")]
    public Text displayText = null;
    [Tooltip("The player gameobject")]
    public GameObject Player = null;

  
    /// <summary>
    /// Description:
    /// Updates the  number of enemies to defeat display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayLivesLeft()
    {
        if (Player != null)
        {
            Health playerHealth = Player.GetComponent<Health>();
            if (displayText != null)
            {
                displayText.text = "Lives Left:" + playerHealth.currentLives.ToString();
            }
        }
    }

    /// <summary>
    /// Description:
    /// Overides the virtual UpdateUI function and uses the DisplayEnemiesToDefeat to update the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void Update()
    {
        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayLivesLeft();

        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

       ;
    }
}
