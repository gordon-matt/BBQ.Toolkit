namespace BBQ.Toolkit.Plugins.SimpleCodeGenerator;

internal interface IDataInputForm<T>
{
    string ModelStructure { get; }

    T Data { get; }
}