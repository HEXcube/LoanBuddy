using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject HomePanel;
    public GameObject SettingsPanel;
    public GameObject AboutPanel;
    public GameObject ARViewPanel;
    public GameObject HelpPanel;
    public GameObject HomeLoanPanel;

    public AudioManager AudioManagerObject;
    public VibrationManager VibrationManagerObject;

    // Start is called before the first frame update
    void Start()
    {
        HomePanel.SetActive(true);
        SettingsPanel.SetActive(false);
        AboutPanel.SetActive(false);
        ARViewPanel.SetActive(false);
        HelpPanel.SetActive(false);
        HomeLoanPanel.SetActive(false);
    }

    public void SetPanel(GameObject One, GameObject Two)
    {
        ButtonClickFeedback();

        One.SetActive(false);
        Two.SetActive(true);
    }

    public void OnScanButtonClick() {
        VuforiaEnableDisable.EnableVuforia();
        SetPanel(HomePanel, ARViewPanel);
    }

    public void OnBackFromARViewPanel() {
        SetPanel(ARViewPanel, HomePanel);
        VuforiaEnableDisable.DisableVuforia();
    }

    public void OnSettingsButtonClick() => SetPanel(HomePanel, SettingsPanel);
    public void OnBackFromSettingsPanel() => SetPanel(SettingsPanel, HomePanel);
    public void OnAboutButtonClick() => SetPanel(HomePanel, AboutPanel);
    public void OnBackFromAboutPanel() => SetPanel(AboutPanel, HomePanel);
    public void OnHelpButtonClick() => SetPanel(ARViewPanel, HelpPanel);
    public void OnBackFromHelpPanel() => SetPanel(HelpPanel, ARViewPanel);
    public void OnHomeLoanButtonClick() => SetPanel(ARViewPanel, HomeLoanPanel);
    public void OnBackFromHomeLoanPanel() => SetPanel(HomeLoanPanel, ARViewPanel);

    public void OnClickQuit()
    {
        ButtonClickFeedback();

        // QuitDialog obj=new QuitDialog();
        // obj.ShowQuitDialog();

        // Use static method instead of creating multiple objects each time
        NativeDialogPlugin.ShowQuitDialog();
    }

    public void OnClickShareApp()
    {
        ButtonClickFeedback();

        // Use static method instead of creating multiple objects each time
        NativeSharePlugin.ShowShareURLMenu("https://hexcube.github.io");
    }

    public void ButtonClickFeedback()
    {
        AudioManagerObject.PlayButtonTouchSound();
        VibrationManagerObject.VibrateCustom();
    }
}
