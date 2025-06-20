using UnityEngine;

public class LevelProgressManager : MonoBehaviour
{
    // Menyimpan index level terakhir yang diselesaikan
    public void SimpanProgressLevel(int levelIndex)
    {
        PlayerPrefs.SetInt("LevelSelesai", levelIndex);
        PlayerPrefs.Save();
        Debug.Log("Progress level disimpan: Level " + levelIndex);
    }

    // Mengambil index level terakhir yang disimpan
    public int AmbilProgressLevel()
    {
        int level = PlayerPrefs.GetInt("LevelSelesai", 0); // default level 0
        Debug.Log("Progress level terakhir: Level " + level);
        return level;
    }

    // Contoh penggunaan saat start game
    void Start()
    {
        int levelTerakhir = AmbilProgressLevel();

        // Misalnya langsung lanjut ke level terakhir (opsional)
        // UnityEngine.SceneManagement.SceneManager.LoadScene(levelTerakhir);
    }
}
