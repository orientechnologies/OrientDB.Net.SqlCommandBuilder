using OrientDB.Net.Core.Models;
using OrientDB.Net.SqlCommandBuilder.Protocol;

// syntax:
// DELETE FROM <Class>|cluster:<cluster>|index:<index> 
// [<Condition>*](WHERE) 
// [BY <Fields>* [ASC|DESC](ORDER)*] 
// [<MaxRecords>](LIMIT)

namespace OrientDB.Net.SqlCommandBuilder
{
    public class SqlDeleteDocument
    {
        private SqlQuery _sqlQuery;

        public SqlDeleteDocument()
        {
            _sqlQuery = new SqlQuery();
        }

        public SqlDeleteDocument Delete<T>(T obj)
        {
            _sqlQuery.Delete(obj);

            return this;
        }

        #region Class

        public SqlDeleteDocument Class(string className)
        {
            _sqlQuery.Class(className);

            return this;
        }

        public SqlDeleteDocument Class<T>()
        {
            return Class(typeof(T).Name);
        }

        #endregion

        #region Cluster

        public SqlDeleteDocument Cluster(string clusterName)
        {
            _sqlQuery.Cluster("cluster:" + clusterName);

            return this;
        }

        public SqlDeleteDocument Cluster<T>()
        {
            return Cluster(typeof(T).Name);
        }

        #endregion

        #region Record

        public SqlDeleteDocument Record(ORID orid)
        {
            _sqlQuery.Record(orid);

            return this;
        }

        public SqlDeleteDocument Record(OrientDBEntity document)
        {
            return Record(document.ORID);
        }

        #endregion

        #region Where with conditions

        public SqlDeleteDocument Where(string field)
        {
            _sqlQuery.Where(field);

            return this;
        }

        public SqlDeleteDocument And(string field)
        {
            _sqlQuery.And(field);

            return this;
        }

        public SqlDeleteDocument Or(string field)
        {
            _sqlQuery.Or(field);

            return this;
        }

        public SqlDeleteDocument Equals<T>(T item)
        {
            _sqlQuery.Equals<T>(item);

            return this;
        }

        public SqlDeleteDocument NotEquals<T>(T item)
        {
            _sqlQuery.NotEquals<T>(item);

            return this;
        }

        public SqlDeleteDocument Lesser<T>(T item)
        {
            _sqlQuery.Lesser<T>(item);

            return this;
        }

        public SqlDeleteDocument LesserEqual<T>(T item)
        {
            _sqlQuery.LesserEqual<T>(item);

            return this;
        }

        public SqlDeleteDocument Greater<T>(T item)
        {
            _sqlQuery.Greater<T>(item);

            return this;
        }

        public SqlDeleteDocument GreaterEqual<T>(T item)
        {
            _sqlQuery.GreaterEqual<T>(item);

            return this;
        }

        public SqlDeleteDocument Like<T>(T item)
        {
            _sqlQuery.Like<T>(item);

            return this;
        }

        public SqlDeleteDocument IsNull()
        {
            _sqlQuery.IsNull();

            return this;
        }

        public SqlDeleteDocument Contains<T>(T item)
        {
            _sqlQuery.Contains<T>(item);

            return this;
        }

        public SqlDeleteDocument Contains<T>(string field, T value)
        {
            _sqlQuery.Contains<T>(field, value);

            return this;
        }

        #endregion

        public SqlDeleteDocument Limit(int maxRecords)
        {
            _sqlQuery.Limit(maxRecords);

            return this;
        }

        public override string ToString()
        {
            return _sqlQuery.ToString(QueryType.DeleteDocument);
        }
    }
}
