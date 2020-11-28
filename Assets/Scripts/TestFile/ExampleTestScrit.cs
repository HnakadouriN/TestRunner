using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ExampleTestScrit
    {
        //BreforeAfterTestAttributeを持たせる
        [Test, BeforeAfterTest]
        public void TestCode()
        {
            Debug.Log("実行");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Testenum()
        {
            Debug.Log("1");
            yield return null;
            Debug.Log("2");
            yield return null;
            Debug.Log("3");
            yield return null;
        }
    }

    public class BeforeAfterTestAttribute : NUnitAttribute, ITestAction
    {
        //Testだと一回ごとに呼び出され、Suiteだと一回だけしか呼ばない
        public ActionTargets Targets => ActionTargets.Test;

        public void AfterTest(ITest test)
        {
            Debug.Log("Test後に呼ばれている");
        }

        public void BeforeTest(ITest test)
        {
            Debug.Log("Test前に呼ばれているよ");
        }
    }
}
