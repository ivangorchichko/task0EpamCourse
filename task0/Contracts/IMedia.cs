﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task0.Contracts
{
    interface IMedia
    {
        void OpenFile(Media media);
        void DeleteFile(Media media);
    }
}
