using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public enum SceneNames {Logo=0,Login, }
public static class Utils
{
    public static string GetActiveScece()
    {
        return SceneManager.GetActiveScene().name;
    }

    public static void LoadScene(string sceneName="")
    {
        if( sceneName == "") 
        {
            SceneManager.LoadScene(GetActiveScece());
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public static void LoadScene(SceneNames sceneName)
    {
        //SceneNames ���������� �Ű������� �޾ƿ� ��� ToString() ó��
        SceneManager.LoadScene(sceneName.ToString());
    }
}
