using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class inherits for the UIelement class and handles updating the score display
/// </summary>
public class EnemiesToDefeatDisplay : UIelement
{
    [Tooltip("The text UI to use for display")]
    public Text displayText = null;

    /// <summary>
    /// Description:
    /// Updates the  number of enemies to defeat display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayEnemiesToDefeat()
    {
        if (displayText != null)
        {
            displayText.text = "Enemies to Defeat: " + (GameManager.instance.enemiesToDefeat - GameManager.instance.enemiesDefeated - 1).ToString();
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
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayEnemiesToDefeat();
    }
}
