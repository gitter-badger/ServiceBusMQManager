#region File Information
/********************************************************************
  Project: ServiceBusMQ
  File:    WarningArgs.cs
  Created: 2013-08-24

  Author(s):
    Daniel Halan

 (C) Copyright 2013 Ingenious Technology with Quality Sweden AB
     all rights reserved

********************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBusMQ.Manager {

  public enum WarningType { ConnectonFailed, Other=0xFF }

  public class WarningArgs : EventArgs {

    public string Message { get; private set; }
    public string Content { get; set; }
    
    public WarningType Type { get; set; }

    public WarningArgs(string message, string content, WarningType type) {
      Message = message;
      Content = content;

      Type = type;
    }


  }
}
