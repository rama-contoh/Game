using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Panel UI")]
    public GameObject panelBenar;
    public GameObject panelSalah;

    // Fungsi saat pemain menjawab dengan benar
    public void JawabanBenar()
    {
        if (panelBenar != null)
            panelBenar.SetActive(true);

        // Simpan level yang telah diselesaikan
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("LevelSelesai", currentLevel);
        PlayerPrefs.Save();

        Debug.Log("Jawaban Benar. Level disimpan: " + currentLevel);
    }

    // Fungsi saat pemain menjawab salah
    public void JawabanSalah()
    {
        if (panelSalah != null)
            panelSalah.SetActive(true);

        Debug.Log("Jawaban Salah.");
    }

    // Fungsi untuk melanjutkan ke level berikutnya
    public void MuatLevelBerikutnya()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextScene < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            Debug.Log("Semua level selesai!");
        }
    }

    // Fungsi untuk kembali ke menu utama
    public void KembaliKeMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
