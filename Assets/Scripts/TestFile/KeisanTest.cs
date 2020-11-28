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
    }
}
