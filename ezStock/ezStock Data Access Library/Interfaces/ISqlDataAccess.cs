
namespace ezStock_Data_Access_Library;
public interface ISqlDataAccess
{
    string ConnectingStringName { get; set; }

    Task<List<T>> LoadData<T, U>(string sql, U parameters);
    Task SaveData<T>(string sql, T parameters);
}