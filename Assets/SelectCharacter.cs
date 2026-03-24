using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public GameObject[] Characters;
    private int Number;

    void Start()
    {
        // Load previously selected character (default = 0)
        Number = PlayerPrefs.GetInt("SelectedCharacter", 0);
        ShowCharacter();
    }

    public void ChangeCharacter(int direction)
    {
        // Wrap index safely
        Number = (Number + direction + Characters.Length) % Characters.Length;
        ShowCharacter();
    }

    public void SelectCurrentCharacter()
    {
        PlayerPrefs.SetInt("SelectedCharacter", Number);
        PlayerPrefs.Save();
       // Debug.Log("Selected Character Index: " + Number);
    }

    void ShowCharacter()
    {
        for (int i = 0; i < Characters.Length; i++)
        {
            Characters[i].SetActive(i == Number);
        }
    }
}