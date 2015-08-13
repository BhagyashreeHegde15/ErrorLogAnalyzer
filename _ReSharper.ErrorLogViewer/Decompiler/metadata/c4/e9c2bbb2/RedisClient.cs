// Type: ServiceStack.Redis.RedisClient
// Assembly: ServiceStack.Redis, Version=4.0.21.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\ErrorLogViewer\packages\ServiceStack.Redis.4.0.21\lib\net40\ServiceStack.Redis.dll

using ServiceStack.Caching;
using ServiceStack.Data;
using ServiceStack.Model;
using ServiceStack.Redis.Generic;
using ServiceStack.Redis.Pipeline;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ServiceStack.Redis
{
  /// <summary>
  /// The client wraps the native redis operations into a more readable c# API.
  /// 
  ///             Where possible these operations are also exposed in common c# interfaces,
  ///             e.g. RedisClient.Lists =&gt; IList[string]
  ///             	 RedisClient.Sets =&gt; ICollection[string]
  /// 
  /// </summary>
  public class RedisClient : RedisNativeClient, IRedisClient, IEntityStore, ICacheClient, IDisposable, IRemoveByPattern
  {
    public static Func<RedisClient> NewFactoryFn;
    public RedisClient();
    public RedisClient(string host);
    public RedisClient(string host, int port);
    public RedisClient(string host, int port, string password = null, long db = 0);
    public RedisClient(Uri uri);
    public IEnumerable<SlowlogItem> GetSlowlog(int? numberOfRecords = null);
    public T Exec<T>(Func<RedisClient, T> action);
    public void Exec(Action<RedisClient> action);
    public void RemoveAll(IEnumerable<string> keys);
    public T Get<T>(string key);
    public long Increment(string key, uint amount);
    public long Decrement(string key, uint amount);
    public bool Add<T>(string key, T value);
    public bool Set<T>(string key, T value);
    public bool Replace<T>(string key, T value);
    public bool Add<T>(string key, T value, DateTime expiresAt);
    public bool Set<T>(string key, T value, TimeSpan expiresIn);
    public bool Set<T>(string key, T value, DateTime expiresAt);
    public bool Replace<T>(string key, T value, DateTime expiresAt);
    public bool Add<T>(string key, T value, TimeSpan expiresIn);
    public bool Replace<T>(string key, T value, TimeSpan expiresIn);
    public IDictionary<string, T> GetAll<T>(IEnumerable<string> keys);
    public void SetAll<T>(IDictionary<string, T> values);
    /// <summary>
    /// Creates a new instance of the Redis Client from NewFactoryFn.
    /// 
    /// </summary>
    public static RedisClient New();
    public void Init();
    public override void OnConnected();
    public DateTime ConvertToServerDate(DateTime expiresAt);
    public string GetTypeSequenceKey<T>();
    public string GetTypeIdsSetKey<T>();
    public string GetTypeIdsSetKey(Type type);
    public void RewriteAppendOnlyFileAsync();
    public List<string> GetAllKeys();
    public void SetEntry(string key, string value);
    public void SetEntry(string key, string value, TimeSpan expireIn);
    public void SetEntryIfExists(string key, string value, TimeSpan expireIn);
    public bool SetEntryIfNotExists(string key, string value);
    public void SetEntryIfNotExists(string key, string value, TimeSpan expireIn);
    public void ChangeDb(long db);
    public List<Dictionary<string, string>> GetClientList();
    public void SetAll(IEnumerable<string> keys, IEnumerable<string> values);
    public void SetAll(Dictionary<string, string> map);
    /// <summary>
    /// Alias for GetValue
    /// 
    /// </summary>
    public string GetEntry(string key);
    public string GetValue(string key);
    public string GetAndSetEntry(string key, string value);
    public bool ContainsKey(string key);
    public bool Remove(string key);
    public bool RemoveEntry(params string[] keys);
    public long IncrementValue(string key);
    public long IncrementValueBy(string key, int count);
    public long IncrementValueBy(string key, long count);
    public double IncrementValueBy(string key, double count);
    public long DecrementValue(string key);
    public long DecrementValueBy(string key, int count);
    public long AppendToValue(string key, string value);
    public void RenameKey(string fromName, string toName);
    public string GetRandomKey();
    public bool ExpireEntryIn(string key, TimeSpan expireIn);
    public bool ExpireEntryAt(string key, DateTime expireAt);
    public TimeSpan GetTimeToLive(string key);
    public void SetConfig(string configItem, string value);
    public string GetConfig(string configItem);
    public DateTime GetServerTime();
    public IRedisTypedClient<T> As<T>();
    public IDisposable AcquireLock(string key);
    public IDisposable AcquireLock(string key, TimeSpan timeOut);
    public IRedisTransaction CreateTransaction();
    public IRedisPipeline CreatePipeline();
    public List<string> SearchKeys(string pattern);
    public List<string> GetValues(List<string> keys);
    public List<T> GetValues<T>(List<string> keys);
    public Dictionary<string, string> GetValuesMap(List<string> keys);
    public Dictionary<string, T> GetValuesMap<T>(List<string> keys);
    public new IRedisSubscription CreateSubscription();
    public long PublishMessage(string toChannel, string message);
    public T GetById<T>(object id);
    public IList<T> GetByIds<T>(ICollection ids);
    public IList<T> GetAll<T>();
    public T Store<T>(T entity);
    public object StoreObject(object entity);
    public void StoreAll<TEntity>(IEnumerable<TEntity> entities);
    public T GetFromHash<T>(object id);
    public void StoreAsHash<T>(T entity);
    public void WriteAll<TEntity>(IEnumerable<TEntity> entities);
    public static byte[] SerializeToUtf8Bytes<T>(T value);
    public void Delete<T>(T entity);
    public void DeleteById<T>(object id);
    public void DeleteByIds<T>(ICollection ids);
    public void DeleteAll<T>();
    public RedisClient CloneClient();
    public long ExecLuaAsInt(string body, params string[] args);
    public long ExecLuaAsInt(string luaBody, string[] keys, string[] args);
    public long ExecLuaShaAsInt(string sha1, params string[] args);
    public long ExecLuaShaAsInt(string sha1, string[] keys, string[] args);
    public string ExecLuaAsString(string body, params string[] args);
    public string ExecLuaAsString(string sha1, string[] keys, string[] args);
    public string ExecLuaShaAsString(string sha1, params string[] args);
    public string ExecLuaShaAsString(string sha1, string[] keys, string[] args);
    public List<string> ExecLuaAsList(string body, params string[] args);
    public List<string> ExecLuaAsList(string luaBody, string[] keys, string[] args);
    public List<string> ExecLuaShaAsList(string sha1, params string[] args);
    public List<string> ExecLuaShaAsList(string sha1, string[] keys, string[] args);
    public bool HasLuaScript(string sha1Ref);
    public Dictionary<string, bool> WhichLuaScriptsExists(params string[] sha1Refs);
    public void RemoveAllLuaScripts();
    public void KillRunningLuaScript();
    public string LoadLuaScript(string body);
    public void RemoveByPattern(string pattern);
    public void RemoveByRegex(string pattern);
    public IEnumerable<string> ScanAllKeys(string pattern = null, int pageSize = 1000);
    public IEnumerable<string> ScanAllSetItems(string setId, string pattern = null, int pageSize = 1000);
    public IEnumerable<KeyValuePair<string, double>> ScanAllSortedSetItems(string setId, string pattern = null, int pageSize = 1000);
    public IEnumerable<KeyValuePair<string, string>> ScanAllHashEntries(string hashId, string pattern = null, int pageSize = 1000);
    public bool AddToHyperLog(string key, params string[] elements);
    public long CountHyperLog(string key);
    public void MergeHyperLogs(string toKey, params string[] fromKeys);
    public bool SetEntryInHash(string hashId, string key, string value);
    public bool SetEntryInHashIfNotExists(string hashId, string key, string value);
    public void SetRangeInHash(string hashId, IEnumerable<KeyValuePair<string, string>> keyValuePairs);
    public long IncrementValueInHash(string hashId, string key, int incrementBy);
    public long IncrementValueInHash(string hashId, string key, long incrementBy);
    public double IncrementValueInHash(string hashId, string key, double incrementBy);
    public string GetValueFromHash(string hashId, string key);
    public bool HashContainsEntry(string hashId, string key);
    public bool RemoveEntryFromHash(string hashId, string key);
    public long GetHashCount(string hashId);
    public List<string> GetHashKeys(string hashId);
    public List<string> GetHashValues(string hashId);
    public Dictionary<string, string> GetAllEntriesFromHash(string hashId);
    public List<string> GetValuesFromHash(string hashId, params string[] keys);
    public List<string> GetAllItemsFromList(string listId);
    public List<string> GetRangeFromList(string listId, int startingFrom, int endingAt);
    public List<string> GetRangeFromSortedList(string listId, int startingFrom, int endingAt);
    public List<string> GetSortedItemsFromList(string listId, SortOptions sortOptions);
    public void AddItemToList(string listId, string value);
    public void AddRangeToList(string listId, List<string> values);
    public void PrependItemToList(string listId, string value);
    public void PrependRangeToList(string listId, List<string> values);
    public void RemoveAllFromList(string listId);
    public string RemoveStartFromList(string listId);
    public string BlockingRemoveStartFromList(string listId, TimeSpan? timeOut);
    public ItemRef BlockingRemoveStartFromLists(string[] listIds, TimeSpan? timeOut);
    public string RemoveEndFromList(string listId);
    public void TrimList(string listId, int keepStartingFrom, int keepEndingAt);
    public long RemoveItemFromList(string listId, string value);
    public long RemoveItemFromList(string listId, string value, int noOfMatches);
    public long GetListCount(string listId);
    public string GetItemFromList(string listId, int listIndex);
    public void SetItemInList(string listId, int listIndex, string value);
    public void EnqueueItemOnList(string listId, string value);
    public string DequeueItemFromList(string listId);
    public string BlockingDequeueItemFromList(string listId, TimeSpan? timeOut);
    public ItemRef BlockingDequeueItemFromLists(string[] listIds, TimeSpan? timeOut);
    public void PushItemToList(string listId, string value);
    public string PopItemFromList(string listId);
    public string BlockingPopItemFromList(string listId, TimeSpan? timeOut);
    public ItemRef BlockingPopItemFromLists(string[] listIds, TimeSpan? timeOut);
    public string PopAndPushItemBetweenLists(string fromListId, string toListId);
    public string BlockingPopAndPushItemBetweenLists(string fromListId, string toListId, TimeSpan? timeOut);
    public List<string> GetSortedEntryValues(string setId, int startingFrom, int endingAt);
    public HashSet<string> GetAllItemsFromSet(string setId);
    public void AddItemToSet(string setId, string item);
    public void AddRangeToSet(string setId, List<string> items);
    public void RemoveItemFromSet(string setId, string item);
    public string PopItemFromSet(string setId);
    public void MoveBetweenSets(string fromSetId, string toSetId, string item);
    public long GetSetCount(string setId);
    public bool SetContainsItem(string setId, string item);
    public HashSet<string> GetIntersectFromSets(params string[] setIds);
    public void StoreIntersectFromSets(string intoSetId, params string[] setIds);
    public HashSet<string> GetUnionFromSets(params string[] setIds);
    public void StoreUnionFromSets(string intoSetId, params string[] setIds);
    public HashSet<string> GetDifferencesFromSet(string fromSetId, params string[] withSetIds);
    public void StoreDifferencesFromSet(string intoSetId, string fromSetId, params string[] withSetIds);
    public string GetRandomItemFromSet(string setId);
    public static double GetLexicalScore(string value);
    public bool AddItemToSortedSet(string setId, string value);
    public bool AddItemToSortedSet(string setId, string value, double score);
    public bool AddItemToSortedSet(string setId, string value, long score);
    public bool AddRangeToSortedSet(string setId, List<string> values, double score);
    public bool AddRangeToSortedSet(string setId, List<string> values, long score);
    public bool RemoveItemFromSortedSet(string setId, string value);
    public string PopItemWithLowestScoreFromSortedSet(string setId);
    public string PopItemWithHighestScoreFromSortedSet(string setId);
    public bool SortedSetContainsItem(string setId, string value);
    public double IncrementItemInSortedSet(string setId, string value, double incrementBy);
    public double IncrementItemInSortedSet(string setId, string value, long incrementBy);
    public long GetItemIndexInSortedSet(string setId, string value);
    public long GetItemIndexInSortedSetDesc(string setId, string value);
    public List<string> GetAllItemsFromSortedSet(string setId);
    public List<string> GetAllItemsFromSortedSetDesc(string setId);
    public List<string> GetRangeFromSortedSet(string setId, int fromRank, int toRank);
    public List<string> GetRangeFromSortedSetDesc(string setId, int fromRank, int toRank);
    public IDictionary<string, double> GetAllWithScoresFromSortedSet(string setId);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSet(string setId, int fromRank, int toRank);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetDesc(string setId, int fromRank, int toRank);
    public List<string> GetRangeFromSortedSetByLowestScore(string setId, string fromStringScore, string toStringScore);
    public List<string> GetRangeFromSortedSetByLowestScore(string setId, string fromStringScore, string toStringScore, int? skip, int? take);
    public List<string> GetRangeFromSortedSetByLowestScore(string setId, double fromScore, double toScore);
    public List<string> GetRangeFromSortedSetByLowestScore(string setId, long fromScore, long toScore);
    public List<string> GetRangeFromSortedSetByLowestScore(string setId, double fromScore, double toScore, int? skip, int? take);
    public List<string> GetRangeFromSortedSetByLowestScore(string setId, long fromScore, long toScore, int? skip, int? take);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, string fromStringScore, string toStringScore);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, string fromStringScore, string toStringScore, int? skip, int? take);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, double fromScore, double toScore);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, long fromScore, long toScore);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, double fromScore, double toScore, int? skip, int? take);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByLowestScore(string setId, long fromScore, long toScore, int? skip, int? take);
    public List<string> GetRangeFromSortedSetByHighestScore(string setId, string fromStringScore, string toStringScore);
    public List<string> GetRangeFromSortedSetByHighestScore(string setId, string fromStringScore, string toStringScore, int? skip, int? take);
    public List<string> GetRangeFromSortedSetByHighestScore(string setId, double fromScore, double toScore);
    public List<string> GetRangeFromSortedSetByHighestScore(string setId, long fromScore, long toScore);
    public List<string> GetRangeFromSortedSetByHighestScore(string setId, double fromScore, double toScore, int? skip, int? take);
    public List<string> GetRangeFromSortedSetByHighestScore(string setId, long fromScore, long toScore, int? skip, int? take);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, string fromStringScore, string toStringScore);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, string fromStringScore, string toStringScore, int? skip, int? take);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, double fromScore, double toScore);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, long fromScore, long toScore);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, double fromScore, double toScore, int? skip, int? take);
    public IDictionary<string, double> GetRangeWithScoresFromSortedSetByHighestScore(string setId, long fromScore, long toScore, int? skip, int? take);
    public long RemoveRangeFromSortedSet(string setId, int minRank, int maxRank);
    public long RemoveRangeFromSortedSetByScore(string setId, double fromScore, double toScore);
    public long RemoveRangeFromSortedSetByScore(string setId, long fromScore, long toScore);
    public long GetSortedSetCount(string setId);
    public long GetSortedSetCount(string setId, string fromStringScore, string toStringScore);
    public long GetSortedSetCount(string setId, double fromScore, double toScore);
    public long GetSortedSetCount(string setId, long fromScore, long toScore);
    public double GetItemScoreInSortedSet(string setId, string value);
    public long StoreIntersectFromSortedSets(string intoSetId, params string[] setIds);
    public long StoreUnionFromSortedSets(string intoSetId, params string[] setIds);
    public List<string> SearchSortedSet(string setId, string start = null, string end = null, int? skip = null, int? take = null);
    public long SearchSortedSetCount(string setId, string start = null, string end = null);
    public long RemoveRangeFromSortedSetBySearch(string setId, string start = null, string end = null);
    public string this[string key] { get; set; }
    public IHasNamed<IRedisHash> Hashes { get; set; }
    public IHasNamed<IRedisList> Lists { get; set; }
    public IHasNamed<IRedisSet> Sets { get; set; }
    public IHasNamed<IRedisSortedSet> SortedSets { get; set; }
  }
}
