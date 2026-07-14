using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger3 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならFalseScene4へ
            SceneManager.LoadScene("FalseScene4");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならTrueScene4へ
            SceneManager.LoadScene("TrueScene4");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
