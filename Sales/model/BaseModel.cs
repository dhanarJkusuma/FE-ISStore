using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Sales.model
{
    public class BaseModel
    {
         protected static String table = "";
        
        public BaseModel()
        {
           
        }


        public class QueryBuilder
        {
            private static String _query = "";

            public QueryBuilder() 
            {
                _query = "SELECT * FROM " + table ;
            }

            public class InnerJoin
            {
                public InnerJoin(String table2)
                {
                    _query += " INNER JOIN " + table2;
                }

                public Result on(String join_condition)
                {
                    _query += " ON " + join_condition;
                    return new Result();
                }
            }

            public class LeftJoin
            {
                public LeftJoin(String table2)
                {
                    _query += " LEFT JOIN " + table2;
                }

                public Result on(String join_condition)
                {
                    _query += " ON " + join_condition;
                    return new Result();
                }

            }

            public InnerJoin innerJoin(String table2)
            {
                return new InnerJoin(table2);
            }

            public LeftJoin leftJoin(String table2) 
            {
                return new LeftJoin(table2);
            }


            public Result Get()
            {
                return new Result();
            }

            public class Result
            {
                public Result()
                {

                }

                public LeftJoin leftJoin(String table2)
                {
                    return new LeftJoin(table2);
                }

                public InnerJoin innerJoin(String table2) 
                {
                    return new InnerJoin(table2);
                }

                public Result and(String andCondition) 
                {
                    _query += " AND " + andCondition;
                    return new Result();
                }

                public Result where(String condition)
                {
                    _query += " WHERE " + condition;
                    return new Result();
                }

                public String Query()
                {
                    return _query;
                }

                public String Query(String[] columns) 
                {
                    return DatabaseBuilder.queryString(_query, columns);
                }

                public DataTable GetData() 
                {
                    return DatabaseBuilder.query(_query);
                }

                public DataTable GetData(String[] columns)
                {
                    return DatabaseBuilder.query(_query, columns);
                }

            }

        }
    }
}
