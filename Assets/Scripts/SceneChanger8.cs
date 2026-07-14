using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger8 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならTrueScene9へ
            SceneManager.LoadScene("TrueScene9");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならFalseScene9へ
            SceneManager.LoadScene("FalseScene9");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
