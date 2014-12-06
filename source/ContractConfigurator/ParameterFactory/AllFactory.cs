﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP;
using Contracts;
using Contracts.Parameters;

namespace ContractConfigurator
{
    /*
     * ParameterFactory to provide logic for All.
     */
    public class AllFactory : ParameterFactory
    {
        public override ContractParameter Generate(Contract contract)
        {
            return new Parameters.All(title);
        }
    }
}
