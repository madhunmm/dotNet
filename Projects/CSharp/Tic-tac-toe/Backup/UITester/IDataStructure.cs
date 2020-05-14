namespace DS
{
    interface IDataStructure
    {
        void    add(object key, object value);
        void    remove(object key);
        object  getValue(object key);
        void    setValue(object key, object value);
    }
}
