﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyRxAutomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyRxAutomationRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("6b9ed2c6-a33f-4001-9581-090832cc21af")]
    public partial class MyRxAutomationRepository : RepoGenBaseFolder
    {
        static MyRxAutomationRepository instance = new MyRxAutomationRepository();

        /// <summary>
        /// Gets the singleton class instance representing the MyRxAutomationRepository element repository.
        /// </summary>
        [RepositoryFolder("6b9ed2c6-a33f-4001-9581-090832cc21af")]
        public static MyRxAutomationRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyRxAutomationRepository() 
            : base("MyRxAutomationRepository", "/", null, 0, false, "6b9ed2c6-a33f-4001-9581-090832cc21af", ".\\RepositoryImages\\MyRxAutomationRepository6b9ed2c6.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("6b9ed2c6-a33f-4001-9581-090832cc21af")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class MyRxAutomationRepositoryFolders
    {
    }
#pragma warning restore 0436
}