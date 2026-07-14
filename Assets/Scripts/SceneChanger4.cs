using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger4 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならFalseScene5へ
            SceneManager.LoadScene("FalseScene5");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならTrueScene5へ
            SceneManager.LoadScene("TrueScene5");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
