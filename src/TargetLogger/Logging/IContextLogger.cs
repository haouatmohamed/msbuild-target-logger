﻿using System;
using JetBrains.Annotations;
using Microsoft.Build.Framework;

namespace TargetLogger.Logging
{
    internal interface IContextLogger
    {
        void Warn([NotNull] BuildEventContext context, [NotNull] string message);
        void Error([NotNull] BuildEventContext context, [NotNull] string message);

        void Track([NotNull] BuildEventContext context, [NotNull] string message);
        void Update([NotNull] BuildEventContext context);
        void Finalize([NotNull] BuildEventContext context, TimeSpan duration, bool succeeded);

        void Indent([NotNull] BuildEventContext context);
        void Outdent([NotNull] BuildEventContext context);
    }
}