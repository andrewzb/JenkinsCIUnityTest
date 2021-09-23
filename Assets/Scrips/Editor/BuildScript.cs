using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildScript : MonoBehaviour
{
    [MenuItem("Assets/BuildGame")]
    public static void PerformBuild() {
        string[] defaultScene = { "Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(defaultScene, $"D:/JenkinsBuilds/sielentBuild/build/{Application.version}/game.exe",
            BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

    [MenuItem("Assets/BuildBundles")]
    public static void BuildBundles() {
        BuildPipeline.BuildAssetBundles("D:/JenkinsBuilds/sielentBuild/bandles",
            BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
}
