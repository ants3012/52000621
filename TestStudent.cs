
using StudentServiceLib;
using Microsoft.VisualStudio.TestTools;

namespace StudentTest

{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Score8_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 8;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7_ReturnB()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 7.0;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score5_ReturnC()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 5.0;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score3AndHaft_ReturnD()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Nguyen Van A";
            s.Age = 20;
            s.Score = 3.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void addFirstStudent_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 1, Name = "Nguyen Van A", Age = 20, Score = 9 };

            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        public void addSecondStudent_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 2, Name = "Nguyen Van A", Age = 20, Score = 8 };

            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        public void addThirdStudent_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 3, Name = "Nguyen Van A", Age = 20, Score = 4 };

            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        public void addFourthStudent_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 4, Name = "Nguyen Van A", Age = 20, Score = 10 };

            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }
    }
}