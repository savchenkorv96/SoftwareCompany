using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany.Client.Common.Helpers
{
    public class OperationStatusInfo
    {
        public string AttachedInfo { get; set; } = string.Empty;
        public object AttachedObject { get; set; }

        public OperationStatus OperationStatus { get; set; }

        public OperationStatusInfo()
        {

        }

        public OperationStatusInfo(OperationStatus operationStatus)
        {
            OperationStatus = operationStatus;
        }

        public OperationStatusInfo(OperationStatus operationStatus, object attachedObject) : this(operationStatus)
        {
            AttachedObject = attachedObject;
        }

        public OperationStatusInfo(OperationStatus operationStatus, string attachedInfo) : this(operationStatus)
        {
            AttachedInfo = attachedInfo;
        }
    }

    public enum OperationStatus
    {
        Done = 0x1,
        Cancelled = 0x2
    }
}
