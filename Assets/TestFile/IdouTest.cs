using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class IdouTest
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator IdouTestWithEnumeratorPasses()
        {
            var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var idou = go.AddComponent<Idou>();
            // Start()前
            Assert.AreEqual(0, idou.count);

            yield return null;

            // Start()後
            Assert.AreEqual(1, idou.count);
            yield return new WaitForSeconds(3);
            Assert.That(go.transform.position == new Vector3(1, 0, 5));
            Debug.Log("いいね");
        }
    }
}
