//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmazingChat.Server.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public long ID { get; set; }
        public long SenderID { get; set; }
        public string SenderName { get; set; }
        public long ReceiverID { get; set; }
        public string Content { get; set; }
        public int Type { get; set; }
        public Nullable<long> GroupID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public bool IsValid { get; set; }
        public string SenderAvatar { get; set; }
        public Nullable<int> Status { get; set; }
    }
}