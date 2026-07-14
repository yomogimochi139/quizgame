using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger6 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならFalseScene7へ
            SceneManager.LoadScene("FalseScene7");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならTrueScene7へ
            SceneManager.LoadScene("TrueScene7");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
