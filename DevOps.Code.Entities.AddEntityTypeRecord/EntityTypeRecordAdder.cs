// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage.Table;
using System.Threading.Tasks;
using static DevOps.Code.Entities.EntityTypeLedger.Builder.EntityTypeTableHelper;
using static DevOps.Code.Entities.GetAzureTable.AzureTableGetter;

namespace DevOps.Code.Entities.AddEntityTypeRecord
{
    /// <summary>Function adds the given entity type information to an Azure Storage Table ledger</summary>
    public static class EntityTypeRecordAdder
    {
        /// <summary>Adds a table entry to an Azure Table named "entities"</summary>
        public static async Task AddEntityTypeAsync(string accountName, string repositoryName, int entityTypeId)
        {
            var entry = EntityTypeTableEntry(accountName, repositoryName, entityTypeId);
            var operation = TableOperation.InsertOrReplace(entry);
            var table = await GetTable();
            await table.ExecuteAsync(operation);
        }
    }
}
