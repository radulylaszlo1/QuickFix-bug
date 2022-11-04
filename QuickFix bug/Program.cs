using QuickFix;
using QuickFix.Fields;
using mtapi.mt5;

namespace TestApp2
{
	class Program
	{
		public static void Main(string[] args)
		{
			TestClass testClass = new TestClass();
			mtapi.mt5.FillPolicy fillPolicy = FillPolicy.FillOrKill;
			testClass.Start();
			Console.WriteLine("done");
			Console.ReadLine();
		}
	}


	class TestClass : QuickFix.IApplication
	{
		public IInitiator MyInitiator;
		public TestClass()
		{
			SessionSettings sessionSettings = new SessionSettings(@"G:\Saját meghajtó\Links\config-LMAXFIX.cfg");
			QuickFix.IMessageStoreFactory storeFactory = new QuickFix.FileStoreFactory(sessionSettings);
			this.MyInitiator = new QuickFix.Transport.SocketInitiator(this, storeFactory, sessionSettings);
		}
		public void Start()
		{
			this.MyInitiator.Start();

		}
		public void FromAdmin(Message message, SessionID sessionID) => throw new NotImplementedException();
		public void FromApp(Message message, SessionID sessionID) => throw new NotImplementedException();
		public void OnCreate(SessionID sessionID) => throw new NotImplementedException();
		public void OnLogon(SessionID sessionID) => throw new NotImplementedException();
		public void OnLogout(SessionID sessionID) => throw new NotImplementedException();
		public void ToAdmin(Message message, SessionID sessionID) => throw new NotImplementedException();
		public void ToApp(Message message, SessionID sessionID) => throw new NotImplementedException();
	}

}