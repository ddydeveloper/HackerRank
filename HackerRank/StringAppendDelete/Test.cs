using Microsoft.VisualBasic;
using NUnit.Framework;

namespace HackerRank.StringAppendDelete
{
    public class Test
    {
        [Test]
        public void CanConvertSimilarEmpty()
        {
            var origin = "";
            var destination = "  ";

            Assert.True(Counter.appendAndDelete(origin, destination, 100));
        } 
        
        [Test]
        public void CanConvertSimilar_NoSteps()
        {
            var origin = "abc";
            var destination = "abc";

            Assert.True(Counter.appendAndDelete(origin, destination, 0));
        } 
        
        [Test]
        public void CanConvertSimilar_MoreSteps()
        {
            var origin = "abc";
            var destination = "abc";

            Assert.True(Counter.appendAndDelete(origin, destination, 7));
        } 
        
        [Test]
        public void CanConvertSimilar_Mod2Steps()
        {
            var origin = "abc";
            var destination = "abc";

            Assert.True(Counter.appendAndDelete(origin, destination, 2));
        } 
        
        [Test]
        public void CanNotConvertSimilar()
        {
            var origin = "abc";
            var destination = "abc";

            Assert.False(Counter.appendAndDelete(origin, destination, 3));
        } 
        
        [Test]
        public void CanConvertEmptyOrigin()
        {
            var origin = "";
            var destination = "defg";

            Assert.True(Counter.appendAndDelete(origin, destination, 4));
        } 
        
        [Test]
        public void CanConvertEmptyOrigin_MoreSteps()
        {
            var origin = "";
            var destination = "defg";

            Assert.True(Counter.appendAndDelete(origin, destination, 7));
        } 
        
        [Test]
        public void CanNotConvertEmptyOrigin()
        {
            var origin = "";
            var destination = "defg";

            Assert.False(Counter.appendAndDelete(origin, destination, 3));
        } 
        
        [Test]
        public void CanConvertToEmpty()
        {
            var origin = "abc";
            var destination = "";

            Assert.True(Counter.appendAndDelete(origin, destination, 3));
        }
        
        [Test]
        public void CanConvertToEmpty_MoreSteps()
        {
            var origin = "abc";
            var destination = "";

            Assert.True(Counter.appendAndDelete(origin, destination, 7));
        }
        
        [Test]
        public void CanNotConvertToEmpty()
        {
            var origin = "abc";
            var destination = "";

            Assert.False(Counter.appendAndDelete(origin, destination, 2));
        }
        
        [Test]
        public void CanConvert()
        {
            var origin = "abc";
            var destination = "defg";

            Assert.True(Counter.appendAndDelete(origin, destination, 7));
        }
        
        [Test]
        public void CanConvert_MoreSteps()
        {
            var origin = "abc";
            var destination = "defg";

            Assert.True(Counter.appendAndDelete(origin, destination, 8));
        }
        
        [Test]
        public void CanConvert_Mod2Steps()
        {
            var origin = "abc";
            var destination = "abef";

            Assert.True(Counter.appendAndDelete(origin, destination, 5));
        }
        
        [Test]
        public void CanNotConvert()
        {
            var origin = "abc";
            var destination = "abef";

            Assert.False(Counter.appendAndDelete(origin, destination, 6));
        }
        
        [Test]
        public void CanNotConvert_HackerRank()
        {
            var origin = "asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv";
            var destination = "bsdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv";

            Assert.False(Counter.appendAndDelete(origin, destination, 100));
        }
    }
}