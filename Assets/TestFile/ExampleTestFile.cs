using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
//if UNITY_EDITORがなければ実際にビルドしたときにコンパイルエラーが起きてしまう
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace ExampleEditorTests
{
    // IPrebuildSetup, IPostBuildCleanupを実装
    public class ExampleTestFile : IPrebuildSetup, IPostBuildCleanup
    {
        [Test]
        public void RelatedToTestPrefab()
        {
            var prefab = Resources.Load<GameObject>("TestPrefab");
            Assert.That(prefab.name == "TestPrefab");
            Assert.That(prefab.GetComponent<MeshFilter>().sharedMesh.name == "Cube");
            Assert.That(prefab.transform.position == Vector3.zero);
        }

        // ビルド前処理
        public void Setup()
        {
#if UNITY_EDITOR
            AssetDatabase.CreateFolder("Assets","Resources");
            var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var path = "Assets/Resources/TestPrefab.prefab";
            PrefabUtility.SaveAsPrefabAsset(go, path);
#endif
        }

        // ビルド後処理
        public void Cleanup()
        {
#if UNITY_EDITOR
            AssetDatabase.DeleteAsset("Assets/Resources");
#endif
        }
    }
}