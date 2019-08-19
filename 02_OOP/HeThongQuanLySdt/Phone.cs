namespace HeThongQuanLySdt
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void updatePhone(string name, string newPhone);
        public abstract void searchPhone(string name);
        public abstract void sort();
    }
}