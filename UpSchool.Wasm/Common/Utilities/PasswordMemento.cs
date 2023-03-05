namespace UpSchool.Wasm.Common.Utilities
{
    public class PasswordMemento
    {
        private string _password;

        public void SetPasswordMemento(string password)
        {
            _password = password;
        }

        public Memento SaveToMemento()
        {
            return new Memento(_password);
        }
        public void RestoreFromMemento(Memento memento){

            _password = memento.GetSavedPassword();
            Console.WriteLine($"restored from memento: {_password}");

            }

        public class Memento
        {
            private string _password;
            public Memento(string password)
            {
                _password = password;
            }
            public string GetSavedPassword()
            {
                return _password;
            }
        }

    }
}
