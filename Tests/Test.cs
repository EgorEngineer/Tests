using Laborat1.JSONWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;

namespace Laborat1.Tests
{
    [Collection("SequentialTests")]
    [TestCaseOrderer("Lab1.Tests.OrderTestCasesBySource", "Lab1.Tests")]
    public class StreamGraphTests: IClassFixture<FlushFixture>
    {

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath1", MemberType = typeof(GetData))]
        public void StreamGraphPath1(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath1", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath2", MemberType = typeof(GetData))]
        public void StreamGraphPath2(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath2", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath3", MemberType = typeof(GetData))]
        public void StreamGraphPath3(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath3", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath4", MemberType = typeof(GetData))]
        public void StreamGraphPath4(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {

            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath4", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));

        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath5", MemberType = typeof(GetData))]
        public void StreamGraphPath5(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath5", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath6", MemberType = typeof(GetData))]
        public void StreamGraphPath6(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath6", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath7", MemberType = typeof(GetData))]
        public void StreamGraphPath7(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath7", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath8", MemberType = typeof(GetData))]
        public void StreamGraphPath8(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath8", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath9", MemberType = typeof(GetData))]
        public void StreamGraphPath9(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath9", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath10", MemberType = typeof(GetData))]
        public void StreamGraphPath10(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath10", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath11", MemberType = typeof(GetData))]
        public void StreamGraphPath11(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath11", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath12", MemberType = typeof(GetData))]
        public void StreamGraphPath12(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath12", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath13", MemberType = typeof(GetData))]
        public void StreamGraphPath13(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath13", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath14", MemberType = typeof(GetData))]
        public void StreamGraphPath14(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath14", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "StreamGraphPath15", MemberType = typeof(GetData))]
        public void StreamGraphPath15(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "StreamGraphPath15", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }
    }

    // Тесты информационного графа
    [Collection("SequentialTests")]
    [TestCaseOrderer("Lab1.Tests.OrderTestCasesBySource", "Lab1.Tests")]
    public class InfGraphTests : IClassFixture<FlushFixture>
    {
        [Theory]
        [MemberData(nameof(GetData.GetTestData), "InfoGraphPath1", MemberType = typeof(GetData))]
        public void InfoGraphPath1(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "InfoGraphPath1", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "InfoGraphPath2", MemberType = typeof(GetData))]
        public void InfoGraphPath2(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "InfoGraphPath2", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "InfoGraphPath3", MemberType = typeof(GetData))]
        public void InfoGraphPath3(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "InfoGraphPath3", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "InfoGraphPath4", MemberType = typeof(GetData))]
        public void InfoGraphPath4(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "InfoGraphPath4", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "InfoGraphPath5", MemberType = typeof(GetData))]
        public void InfoGraphPath5(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            SaveData.WriteDataToJson(null, "InfoGraphPath5", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }
    }

    // Тесты областей эквивалентности
    [Collection("SequentialTests")]
    [TestCaseOrderer("Laborat1.Tests.OrderTestCasesBySource", "Laborat1.Tests")]
    public class EquivalenceClassTests : IClassFixture<FlushFixture>
    {

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass1", MemberType = typeof(GetData))]
        public void EquivalenceClass1_EmptyArray(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass1", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass1", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass2", MemberType = typeof(GetData))]
        public void EquivalenceClass2_MultipleElements(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass2", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass2", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass3", MemberType = typeof(GetData))]
        public void EquivalenceClass3_SingleElement(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass3", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass3", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass4", MemberType = typeof(GetData))]
        public void EquivalenceClass4_1023Elements(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass4", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass4", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass5", MemberType = typeof(GetData))]
        public void EquivalenceClass5_1024Elements(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass5", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass5", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass6", MemberType = typeof(GetData))]
        public void EquivalenceClass6_1025Elements(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass6", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass6", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass7", MemberType = typeof(GetData))]
        public void EquivalenceClass7_MaxIntElement(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass7", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass7", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass8", MemberType = typeof(GetData))]
        public void EquivalenceClass8_MinIntElement(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass8", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass8", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass9", MemberType = typeof(GetData))]
        public void EquivalenceClass9_SumOverflow(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass9", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass9", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass10", MemberType = typeof(GetData))]
        public void EquivalenceClass10_NoPositiveEven(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass10", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass10", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass11", MemberType = typeof(GetData))]
        public void EquivalenceClass11_LargeElements(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass11", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass11", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass12", MemberType = typeof(GetData))]
        public void EquivalenceClass12_CubeAboveIntMax(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass12", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass12", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass13", MemberType = typeof(GetData))]
        public void EquivalenceClass13_CubeBelowIntMin(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass13", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass13", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass14", MemberType = typeof(GetData))]
        public void EquivalenceClass14_CubeOutOfLong(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass14", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass14", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass15", MemberType = typeof(GetData))]
        public void EquivalenceClass15_ValidCubeInInt(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass15", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass15", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass16", MemberType = typeof(GetData))]
        public void EquivalenceClass16_EvenPositiveAtStart(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass16", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass16", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass17", MemberType = typeof(GetData))]
        public void EquivalenceClass17_EvenPositiveInMiddle(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass17", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass17", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        [Theory]
        [MemberData(nameof(GetData.GetTestData), "EquivalenceClass18", MemberType = typeof(GetData))]
        public void EquivalenceClass18_EvenPositiveAtEnd(int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors)
        {
            var (actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = FirstChet.ProcessArray(input);
            LogTest("EquivalenceClass18", input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            SaveData.WriteDataToJson(null, "EquivalenceClass18", actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors);
            Assert.Equal(expectedIndex, actualIndex);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedSum, actualSum);
            Assert.Equal(expectedCube, actualCube);
            Assert.True((expectedTransformedArray ?? new int[0]).SequenceEqual(actualTransformedArray ?? new int[0]));
            Assert.True((expectedErrors ?? new List<string>()).SequenceEqual(actualErrors ?? new List<string>()));
        }

        private void LogTest(string testName, int[] input, int expectedIndex, int expectedValue, long expectedSum, long expectedCube, int[] expectedTransformedArray, List<string> expectedErrors, int actualIndex, int actualValue, long actualSum, long actualCube, int[] actualTransformedArray, List<string> actualErrors)
        {
            Console.WriteLine($"Test: {testName}");
            Console.WriteLine($"Input: [{string.Join(",", input ?? new int[0])}]");
            Console.WriteLine($"Expected: Index={expectedIndex}, Value={expectedValue}, Sum={expectedSum}, Cube={expectedCube}, Transformed=[{string.Join(",", expectedTransformedArray ?? new int[0])}], Errors=[{string.Join(",", expectedErrors ?? new List<string>())}]");
            Console.WriteLine($"Actual: Index={actualIndex}, Value={actualValue}, Sum={actualSum}, Cube={actualCube}, Transformed=[{string.Join(",", actualTransformedArray ?? new int[0])}], Errors=[{string.Join(",", actualErrors ?? new List<string>())}]");
        }
    }
}