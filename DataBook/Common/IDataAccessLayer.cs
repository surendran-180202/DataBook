using System.Collections;
using System;
using System.Collections.Generic;

namespace DataBook
{
    public interface IDataAccessLayer
    {
        bool AddDBData();

        bool UpdateDBData();

        bool DeleteDBData();

        ICollection GetDBData();

        ICollection GetDBData(Guid uqId);

        ICollection GetDBData(string strCondition);
    }
}