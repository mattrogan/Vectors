namespace VectorNS;

[TestClass]
public class VectorTests
{

    [TestMethod]
    public void TestPrint()
    {
        // Arrange
        float[] dims = { 1, 2, 3 };
        Vector v = new(dims);

        // Act
        string expected = "<1, 2, 3>";
        string actual = v.ToString();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestGetters()
    {
        // Arrange
        float[] dims = { 3, 2 };
        Vector v = new(dims);

        // Act
        float x, y;
        x = v.Get(0);
        y = v.Get(1);


        // Assert
        Assert.AreEqual(x, 3);
        Assert.AreEqual(y, 2);
    }


    [TestMethod]
    public void TestSetters()
    {
        // Arrange
        float[] dims = { 0, 0 };
        Vector v = new(dims);

        // Act
        v.Set(0, 3);
        v.Set(1, 2);

        // Assert
        Assert.AreEqual(3, v.Get(0));
        Assert.AreEqual(2, v.Get(1));
    }

    [TestMethod]
    public void TestScalarProduct()
    {
        float[] originalDims = { 3, 2 };
        float[] expectedDims = { 9, 6 };

        Vector original, expected, actual;
        original = new(originalDims);
        expected = new(expectedDims);
        actual = original.ScalarProduct(3);

        Assert.AreEqual(expected, actual);


    }

    [TestMethod]
    public void TestEquality()
    {
        float[] dims = { 1, 2, 3 };
        Vector v1, v2, v3;
        v1 = new(dims);
        v2 = new(dims);
        v3 = new(dims);

        // Reflexive
        Assert.AreEqual(v1, v1);

        // Symmetric
        Assert.IsTrue((v1.Equals(v2)) && (v2.Equals(v1)));

        // Transitive
        if ((v1.Equals(v2) && (v2.Equals(v3))))
        {
            Assert.IsTrue(v1.Equals(v3));
        }
    }

    [TestMethod]
    public void TestInequalityWithNull()
    {
        float[] dims1 = { 3, 2 };
        float[] dims2 = { 1, -1 };
        Vector v1 = new(dims1);
        Vector v2 = new(dims2);
        Vector v3 = new();

        Assert.IsFalse(v1.Equals(null));
        Assert.IsFalse(v2.Equals(null));
        Assert.IsFalse(v3.Equals(null));
    }

    [TestMethod]
    public void TestInequalityWithInvalidTypes()
    {
        float[] dims1 = { 3, 2 };
        float[] dims2 = { 1, -1 };
        Vector v1 = new(dims1);
        Vector v2 = new(dims2);

        Assert.IsFalse(v1.Equals("<3, 2>"));
        Assert.IsFalse(v2.Equals(dims2));
    }

    [TestMethod]
    public void TestAddition()
    {
        // Arrange
        float[] dims1 = { 3, 2, 0 };
        float[] dims2 = { 1, -1, 2 };
        float[] dims3 = { 4, 1, 2 };
        Vector v1, v2, expected, actual;
        v1 = new(dims1);
        v2 = new(dims2);

        // Act
        actual = v1.Add(v2);
        expected = new(dims3);

        // Assert
        Assert.IsTrue(actual.Equals(expected));
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidDataException),
        "dimensions must be equal")]
    public void TestInvalidAddition()
    {
        // Arrange
        float[] dims1 = { 3, 2 };
        float[] dims2 = { 1, -1, 2 };
        Vector v1, v2;

        // Act
        v1 = new(dims1);
        v2 = new(dims2);

        // Assert
        v1.Add(v2);


    }







}
