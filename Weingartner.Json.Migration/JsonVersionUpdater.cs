﻿using Newtonsoft.Json.Linq;
using Weingartner.Json.Migration.Common;

namespace Weingartner.Json.Migration
{
    public class JsonVersionUpdater : IUpdateVersions<JToken>
    {
        public int GetVersion(JToken data)
        {
            if (!(data is JObject)) return 0;

            var versionToken = data[VersionMemberName.Instance.VersionPropertyName];
            return versionToken != null
                ? versionToken.Value<int>()
                : 0;
        }


        public void SetVersion(JToken data, int version)
        {
            if (!(data is JObject)) return;
            data[VersionMemberName.Instance.VersionPropertyName] = version;
        }
    }
}
