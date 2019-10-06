﻿using JetBrains.Annotations;
using Microsoft.Build.Framework;

namespace TargetLogger.Logging
{
    internal interface IContextLogger
    {
        LoggerVerbosity Verbosity { get; }
        void Warn([NotNull] string message);
        void Error([NotNull] string message);
        void Track(int id, [NotNull] string message);
        void Update(int id);
        void Finalize(int id, bool succeeded);
    }
}