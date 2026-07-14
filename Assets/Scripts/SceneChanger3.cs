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
            // imageAがアクティブならFalseScene3へ
            SceneManager.LoadScene("FalseScene3");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならTrueScene3へ
            SceneManager.LoadScene("TrueScene3");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
