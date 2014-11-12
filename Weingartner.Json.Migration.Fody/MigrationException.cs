﻿using System;
using System.Runtime.Serialization;

namespace Weingartner.Json.Migration.Fody
{
    [Serializable]
    public class MigrationException : Exception
    {
        public MigrationException()
        {
        }

        public MigrationException(string message) : base(message)
        {
        }

        public MigrationException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MigrationException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}