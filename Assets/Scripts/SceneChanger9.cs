using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger9 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならTrueScene10へ
            SceneManager.LoadScene("TrueScene10");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならFalseScene10へ
            SceneManager.LoadScene("FalseScene10");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
