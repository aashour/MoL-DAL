using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core;
using MoL.Core.Data;

namespace MoL.Data
{
    public partial class EFDataProviderManager : BaseDataProviderManager
    {
        public EFDataProviderManager(DataSettings settings)
            : base(settings)
        {
        }

        public override IDataProvider LoadDataProvider()
        {

            var providerName = Settings.DataProvider;
            if (String.IsNullOrWhiteSpace(providerName))
                throw new MoLException("Data Settings doesn't contain a providerName");

            switch (providerName.ToLowerInvariant())
            {
                case "sqlserver":
                    return new SqlServerDataProvider();
                //case "sqlce":
                //    return new SqlCeDataProvider();
                default:
                    throw new MoLException(string.Format("Not supported dataprovider name: {0}", providerName));
            }
        }
    }
}
