// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output for the task that gets the list of tables contained within a
    /// provided list of Oracle schemas.
    /// </summary>
    public partial class GetUserTablesOracleTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the GetUserTablesOracleTaskOutput
        /// class.
        /// </summary>
        public GetUserTablesOracleTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetUserTablesOracleTaskOutput
        /// class.
        /// </summary>
        /// <param name="schemaName">The schema this result is for</param>
        /// <param name="tables">List of valid tables found for this
        /// schema</param>
        /// <param name="validationErrors">Validation errors associated with
        /// the task</param>
        public GetUserTablesOracleTaskOutput(string schemaName = default(string), IList<DatabaseTable> tables = default(IList<DatabaseTable>), IList<ReportableException> validationErrors = default(IList<ReportableException>))
        {
            SchemaName = schemaName;
            Tables = tables;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the schema this result is for
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; private set; }

        /// <summary>
        /// Gets list of valid tables found for this schema
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<DatabaseTable> Tables { get; private set; }

        /// <summary>
        /// Gets validation errors associated with the task
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}
