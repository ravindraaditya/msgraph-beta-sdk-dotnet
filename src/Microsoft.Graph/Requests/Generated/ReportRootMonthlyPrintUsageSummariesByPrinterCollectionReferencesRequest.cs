// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequest.
    /// </summary>
    public partial class ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequest : BaseRequest, IReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        public Task AddAsync(PrintUsageSummaryByPrinter PrintUsageSummaryByPrinter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(PrintUsageSummaryByPrinter PrintUsageSummaryByPrinter, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
