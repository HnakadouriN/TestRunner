using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Tests
{
    public class SpherePositionTest
    {

        // A Test behaves as an ordinary method
        [Test]
        public void CreateCapsule()
        {
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Sphere.prefab");
            Assert.That(prefab.transform.localEulerAngles == Vector3.zero);
            Debug.Log("localEulerAngle = " + prefab.transform.localEulerAngles);
        }
    }
}
