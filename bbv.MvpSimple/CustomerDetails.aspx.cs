﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomerDetails.aspx.cs" company="bbv Software Services AG">
//   Copyright (c) 2014
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace bbv.MvpSimple
{
    using System;
    using System.Web.UI;

    using bbv.SampleCore;

    public partial class CustomerDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string customerId = Request.Params["id"];
            if (customerId == null)
            {
                return;
            }

            var repo = new CustomerRepository();

            this.dvDetails.DataSource = new[] { repo.Get(customerId) };
            this.dvDetails.DataBind();
        }
    }
}