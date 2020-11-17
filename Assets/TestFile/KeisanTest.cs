using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Tests;

namespace Tests
{
    public class KeisanTest
    {
        private Keisan keisan;
        // A Test behaves as an ordinary method
        [Test]
        public void KeisanTestSimplePasses()
        {
            keisan = new Keisan();
            // Use the Assert class to test conditions
            Assert.That(1 < 2);
            Assert.That(keisan.Kakezan(2, 4) > keisan.Tasizan(2, 4));
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator KeisanTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
