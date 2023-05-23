using Ex31_ObserverPattern1;

namespace MSTest_Test_Project
{

    [TestClass]
    public class UnitTest1
    {
        ConcreteSubject cSubject;
        ConcreteObserver cObserver1, cObserver2, cObserver3;

        [TestInitialize]
        // Inizialize observers and subjects
        public void Initialize()
        {
            // Inizializing a new subject
            cSubject = new ConcreteSubject();

            // Inizializing a new observers of the subject
            cObserver1 = new ConcreteObserver(cSubject);
            cObserver2 = new ConcreteObserver(cSubject);
            cObserver3 = new ConcreteObserver(cSubject);

            // Attaching the new observers to the subject
            cSubject.Attach(cObserver1);
            cSubject.Attach(cObserver2);
            cSubject.Attach(cObserver3);
        }

        [TestMethod]
        // Testing if an update in the subjects state notifies all the observers state
        public void TestObserverPattern()
        {
            cSubject.State = 1;
            Assert.AreEqual(1, cObserver1.State);
            Assert.AreEqual(1, cObserver2.State);
            Assert.AreEqual(1, cObserver3.State);

            cSubject.State = 25;
            Assert.AreEqual(25, cObserver1.State);
            Assert.AreEqual(25, cObserver2.State);
            Assert.AreEqual(25, cObserver3.State);

            cSubject.Detach(cObserver2);
            cSubject.State = 42;
            Assert.AreEqual(42, cObserver1.State);
            Assert.AreEqual(25, cObserver2.State);
            Assert.AreEqual(42, cObserver3.State);
        }
    }

}