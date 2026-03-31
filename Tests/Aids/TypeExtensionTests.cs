using Abc.Aids;

namespace Abc.Tests.Aids
{
    [TestClass] public class TypeExtensionTests: TestAids
    {
        [TestInitialize] public void Inialize() => type = typeof(TypeExtension);
        [TestMethod] public void IsBoolTest()
        {
            IsTrue(TypeExtension.IsBool(typeof(bool)));
            IsTrue(typeof(bool).IsBool());
            IsFalse(TypeExtension.IsBool(typeof(string)));
        }
        [TestMethod] public void IsBoolNullableTest()
        {
            IsTrue(TypeExtension.IsBool(typeof(bool?)));
        }
        [TestMethod] public void IsDateTest()
        {
            IsTrue(TypeExtension.IsDate(typeof(DateTime)));
            IsTrue(typeof(DateTime).IsDate());
            IsFalse(TypeExtension.IsDate(typeof(string)));

            IsTrue(TypeExtension.IsDate(typeof(DateOnly)));
            IsTrue(typeof(DateOnly).IsDate());
            IsFalse(TypeExtension.IsDate(typeof(string)));
        }
        [TestMethod] public void IsDateNullableTest()
        {
            IsTrue(TypeExtension.IsDate(typeof(DateOnly?)));
            IsTrue(TypeExtension.IsDate(typeof(DateTime?)));
            IsFalse(TypeExtension.IsDate(typeof(int?)));
        }
        [TestMethod] public void IsStringTest()
        {
            IsTrue(TypeExtension.IsString(typeof(string)));
            IsTrue(typeof(string).IsString());
            IsFalse(TypeExtension.IsString(typeof(int)));
            IsFalse(TypeExtension.IsString(typeof(DateTime)));
        }

        [DataRow(typeof(sbyte))] // small signed integer
        [DataRow(typeof(sbyte?))]
        [DataRow(typeof(byte))] // small unsigned integer
        [DataRow(typeof(byte?))]
        [DataRow(typeof(int))] // standard signed integer type
        [DataRow(typeof(int?))]
        [DataRow(typeof(double))] // floating-point number
        [DataRow(typeof(double?))]
        [TestMethod] public void IsNumericTest(Type t)
        {
            IsTrue(TypeExtension.IsNumeric(t));
            IsTrue(t.IsNumeric());
        }
    }
}
