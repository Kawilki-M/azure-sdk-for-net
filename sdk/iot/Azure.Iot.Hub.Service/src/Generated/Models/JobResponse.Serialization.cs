// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class JobResponse
    {
        internal static JobResponse DeserializeJobResponse(JsonElement element)
        {
            Optional<string> jobId = default;
            Optional<string> queryCondition = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<long> maxExecutionTimeInSeconds = default;
            Optional<JobResponseType> type = default;
            Optional<CloudToDeviceMethodRequest> cloudToDeviceMethod = default;
            Optional<TwinData> updateTwin = default;
            Optional<JobResponseStatus> status = default;
            Optional<string> failureReason = default;
            Optional<string> statusMessage = default;
            Optional<DeviceJobStatistics> deviceJobStatistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryCondition"))
                {
                    queryCondition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("maxExecutionTimeInSeconds"))
                {
                    maxExecutionTimeInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new JobResponseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMethod"))
                {
                    cloudToDeviceMethod = CloudToDeviceMethodRequest.DeserializeCloudToDeviceMethodRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("updateTwin"))
                {
                    updateTwin = TwinData.DeserializeTwinData(property.Value);
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new JobResponseStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failureReason"))
                {
                    failureReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusMessage"))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceJobStatistics"))
                {
                    deviceJobStatistics = DeviceJobStatistics.DeserializeDeviceJobStatistics(property.Value);
                    continue;
                }
            }
            return new JobResponse(jobId.Value, queryCondition.Value, Optional.ToNullable(createdTime), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(maxExecutionTimeInSeconds), Optional.ToNullable(type), cloudToDeviceMethod.Value, updateTwin.Value, Optional.ToNullable(status), failureReason.Value, statusMessage.Value, deviceJobStatistics.Value);
        }
    }
}
