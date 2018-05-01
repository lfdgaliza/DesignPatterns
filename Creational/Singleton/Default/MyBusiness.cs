namespace Default
{
    public class MyBusiness
    {
        /// <summary>
        /// Some property to test
        /// </summary>
        public string SomeString => "It works!";

        /// <summary>
        /// This protects this class to be instantiated outside itself
        /// </summary>
        private MyBusiness() { }

        /// <summary>
        /// The only instance
        /// </summary>
        private static MyBusiness _instance;
        public static MyBusiness Instance
        {
            get
            {
                if (MyBusiness._instance == null)
                    MyBusiness._instance = new MyBusiness();
                return MyBusiness._instance;
            }
        }
    }
}