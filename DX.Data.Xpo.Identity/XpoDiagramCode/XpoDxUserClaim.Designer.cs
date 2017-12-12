﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DX.Data.Xpo.Identity.Persistent
{

    [Persistent(@"DXUserClaims")]
    public partial class XpoDxUserClaim : XpoDxBase
    {
        XpoDxUser _User;
        [Indexed(@"ClaimType", Name = @"IdxUserClaim", Unique = true)]
        [Association(@"XpoDxUserClaims")]
        public XpoDxUser User
        {
            get { return _User; }
            set { SetPropertyValue<XpoDxUser>("User", ref _User, value); }
        }
        string _ClaimType;
        [Size(150)]
        public string ClaimType
        {
            get { return _ClaimType; }
            set { SetPropertyValue<string>("ClaimType", ref _ClaimType, value); }
        }
        string _ClaimValue;
        [Size(150)]
        public string ClaimValue
        {
            get { return _ClaimValue; }
            set { SetPropertyValue<string>("ClaimValue", ref _ClaimValue, value); }
        }
        [PersistentAlias("[User!Key]")]
        public string UserId
        {
            get { return (string)(EvaluateAlias("UserId")); }
        }
    }

}
