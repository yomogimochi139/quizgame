using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger7 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならTrueScene8へ
            SceneManager.LoadScene("TrueScene8");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならFalseScene8へ
            SceneManager.LoadScene("FalseScene8");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
