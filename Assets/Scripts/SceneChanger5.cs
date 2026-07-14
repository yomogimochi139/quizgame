using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger5 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならFalseScene6へ
            SceneManager.LoadScene("FalseScene6");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならTrueScene6へ
            SceneManager.LoadScene("TrueScene6");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
