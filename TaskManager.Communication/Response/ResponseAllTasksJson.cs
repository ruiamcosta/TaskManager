﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Communication.Response;
public class ResponseAllTasksJson
{
    public List<ResponseShortTaskJson> Tasks { get; set; } = [];
}
