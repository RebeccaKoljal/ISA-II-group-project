using Abc.Aids;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Tests.Aids
{
    [TestClass] public class TypeExtensionTests: TestAids
    {
        [TestInitialize] public void Inialize() => type = typeof(TypeExtension);
        [TestMethod] public void IsBoolTest() 
        { 
            Assert.IsTrue(TypeExtension.IsBool(typeof(bool))); 
            Assert.IsTrue(typeof(bool).IsBool());
            Assert.IsFalse(TypeExtension.IsBool(typeof(string))); 
        }
        [TestMethod] public void IsBoolNullableTest() 
        {
            Assert.IsTrue(TypeExtension.IsBool(typeof(bool?)));
            Assert.IsFalse(TypeExtension.IsBool(typeof(int?)));
        }
        [TestMethod] public void IsDateTest() 
        {
            Assert.IsTrue(TypeExtension.IsDate(typeof(DateTime)));
            Assert.IsTrue(typeof(DateTime).IsDate());
            Assert.IsFalse(TypeExtension.IsDate(typeof(string)));
            Assert.IsTrue(TypeExtension.IsDate(typeof(DateOnly)));
            Assert.IsTrue(typeof(DateOnly).IsDate());
            Assert.IsFalse(TypeExtension.IsDate(typeof(int)));
        }
        [TestMethod] public void IsDateNullableTest()
        {
            Assert.IsTrue(TypeExtension.IsDate(typeof(DateTime?)));
            Assert.IsTrue(TypeExtension.IsDate(typeof(DateOnly?)));
            Assert.IsFalse(TypeExtension.IsDate(typeof(int?)));
        }
        [TestMethod] public void IsStringTest()
        {
            Assert.IsTrue(TypeExtension.IsString(typeof(string)));
            Assert.IsTrue(typeof(string).IsString());
            Assert.IsFalse(TypeExtension.IsString(typeof(int)));
            Assert.IsFalse(TypeExtension.IsString(typeof(DateTime)));
        }

        [DataRow(typeof(sbyte))]
        [DataRow(typeof(sbyte?))]
        [DataRow(typeof(byte))]
        [DataRow(typeof(byte?))]
        [TestMethod] public void IsNumericTest(Type t) 
        {
            Assert.IsTrue(TypeExtension.IsNumeric(t));
            Assert.IsTrue(t.IsNumeric());
        }
    }
}
