using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Tests
{
    public class SpherePositionTest:IPrebuildSetup ,IPostBuildCleanup
    {

        // A Test behaves as an ordinary method
        [Test]
        public void SpherePositionTestSimplePasses()
        {
            
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SpherePositionTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        public void Setup()
        {
            string path = "Assets/Prefabs/Cube.prefab";
            var obj = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        }

        public void Cleanup()
        {
            throw new System.NotImplementedException();
        }
    }
}
